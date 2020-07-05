using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using proj_reader.Models;
using proj_reader.Controllers;
using System.Globalization;
using Microsoft.Office.Interop.Word;

namespace proj_reader.Views
{
    public partial class frmHome : Form
    {

        //Fields

        PdfiumViewer.PdfViewer pdf;        
        string filePath = "";
        List<string> listKind;

        public frmHome()
        {
            InitializeComponent();
            pdf = new PdfViewer();            
            pdf.Dock = DockStyle.Fill;
            this.panelReadDocument.Controls.Add(pdf);          

            //show data from db

            this.listBoxNearOpen.Items.Clear();

            List<Note> listNearOpen = NoteController.getListNote();            

            //sort by time
            for (int i = 0; i < listNearOpen.Count; i++)
            {
                for (int j = listNearOpen.Count - 1; j > i; j--)
                {
                    if(DateTime.Compare(listNearOpen[j].publishAt.Value, listNearOpen[j - 1].publishAt.Value) < 0)
                    {
                        Note noteTemp = listNearOpen[j];
                        listNearOpen[j] = listNearOpen[j - 1];
                        listNearOpen[j - 1] = noteTemp;
                    }
                }
            }

            for (int i = listNearOpen.Count - 1; i >= 0; i--)
            {
                listBoxNearOpen.Items.Add(listNearOpen[i].filePath.ToString());                
            }

            this.listBoxKind.Items.Clear();
            listBoxKind.Items.Add("None");

            List<Kind> listKinds = KindController.getListKind();

            for (int i = 0; i < listKinds.Count; i++)
            {                
                listBoxKind.Items.Add(listKinds[i].kind);
            }

            //add data to comboBox

            List<Kind> kinds = KindController.getListKind();
            
            for (int i = 0; i < kinds.Count; i++)
            {
                lbKind.Items.Add(kinds[i].kind);                
            }

            listKind = new List<string>();
        }
   

        public void openFile(string filePath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filePath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }   
        
        private void openFileWord(string filePath)
        {
            Microsoft.Office.Interop.Word.Document document;
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
            document = application.Documents.Open(filePath);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            IDataObject dataObject = Clipboard.GetDataObject();
            txtText.Text = dataObject.GetData(DataFormats.Rtf).ToString();
            application.Quit();
        }
        private void showKind(string filePath)
        {
            List<Link> listLink = LinkController.getListLinks(filePath);

            lbChooseKind.Items.Clear();
            listKind.Clear();

            for (int i = 0; i < listLink.Count; i++)
            {
                lbChooseKind.Items.Add(listLink[i].kind);
                listKind.Add(listLink[i].kind);
            }
        }
              
        private async void btnSelect_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string extention = dialog.FileName.Substring(dialog.FileName.Length - 3);

                if (extention == "pdf")
                {
                    this.panelReadDocument.Controls.Add(pdf);
                    txtText.Visible = false;

                    openFile(dialog.FileName);
                }
                else if (extention == "doc" || extention == "ocx")
                {
                    this.panelReadDocument.Controls.Remove(pdf);
                    txtText.Visible = true;

                    openFileWord(dialog.FileName);
                }
                else if (extention == "txt")
                {
                    this.panelReadDocument.Controls.Remove(pdf);
                    txtText.Visible = true;

                    using (StreamReader sr = new StreamReader(dialog.FileName))
                    {
                        txtText.Text = await sr.ReadToEndAsync();
                    }
                }

                filePath = dialog.FileName;

                //showKind
                showKind(filePath);

                //add fileName open to database
                //TODO                               
                //check exists

                Note noteCheck = NoteController.getNote(dialog.FileName);

                if(noteCheck == null)
                {
                    Note note = new Note();
                    note.filePath = dialog.FileName;
                    //add list kind
                    note.publishAt = DateTime.Now;
                    note.note = "";
                    //add data to database
                    if (NoteController.addNote(note) == false)
                    {
                        MessageBox.Show("Error add note");
                    }
                    txtNote.Text = "";
                }
                else
                {                                       
                    txtNote.Text = noteCheck.note;
                    noteCheck.publishAt = DateTime.Now;
                    NoteController.updateNote(noteCheck);
                }               

                this.listBoxNearOpen.Items.Clear();

                List<Note> listNearOpen = NoteController.getListNote();                

                //sort by time
                for (int i = 0; i < listNearOpen.Count; i++)
                {
                    for (int j = listNearOpen.Count - 1; j > i; j--)
                    {
                        if (DateTime.Compare(listNearOpen[j].publishAt.Value, listNearOpen[j - 1].publishAt.Value) < 0)
                        {
                            Note noteTemp = listNearOpen[j];
                            listNearOpen[j] = listNearOpen[j - 1];
                            listNearOpen[j - 1] = noteTemp;
                        }
                    }
                }

                for (int i = listNearOpen.Count - 1; i >= 0; i--)
                {                    
                    listBoxNearOpen.Items.Add(listNearOpen[i].filePath.ToString());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (filePath != "")
            {
                //check exists
                Note noteCheck = NoteController.getNote(filePath);
                noteCheck.note = txtNote.Text;

                List<Link> listLink = LinkController.getListLinks(filePath);

                if(listKind != null)
                {
                    for (int i = 0; i < listLink.Count; i++)
                    {
                        Link link = listLink[i];
                        LinkController.deleteLink(link);
                    }
                }

                for (int i = 0; i < lbChooseKind.Items.Count; i++)
                {
                    Link link = new Link();
                    link.kind = lbChooseKind.Items[i].ToString();
                    link.note = filePath;
                    LinkController.addLink(link);
                }
                
                NoteController.updateNote(noteCheck);
            }
        }

        private async void listBoxNearOpen_Click(object sender, EventArgs e)
        {            
            if (listBoxNearOpen.SelectedIndex >= 0)
            {
                filePath = listBoxNearOpen.SelectedItem.ToString();

                string extention = filePath.Substring(filePath.Length - 3);

                if (extention == "pdf")
                {
                    this.panelReadDocument.Controls.Add(pdf);
                    txtText.Visible = false;

                    openFile(filePath);
                }
                else if (extention == "doc" || extention == "ocx")
                {
                    this.panelReadDocument.Controls.Remove(pdf);
                    txtText.Visible = true;


                    openFileWord(filePath);
                }
                else if (extention == "txt")
                {
                    this.panelReadDocument.Controls.Remove(pdf);
                    txtText.Visible = true;

                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        txtText.Text = await sr.ReadToEndAsync();
                    }
                }

                showKind(filePath);

                //check exists

                Note noteCheck = NoteController.getNote(filePath);

                if (noteCheck == null)
                {
                    Note note = new Note();
                    note.filePath = filePath;
                    //add listKind
                    note.publishAt = DateTime.Now;
                    note.note = "";
                    //add data to database
                    if (NoteController.addNote(note) == false)
                    {
                        MessageBox.Show("Error add note");
                    }
                    txtNote.Text = "";
                }
                else
                {
                    txtNote.Text = noteCheck.note;
                    noteCheck.publishAt = DateTime.Now;
                    NoteController.updateNote(noteCheck);
                }

                this.listBoxNearOpen.Items.Clear();

                List<Note> listNearOpen = NoteController.getListNote();

                //sort by time
                for (int i = 0; i < listNearOpen.Count; i++)
                {
                    for (int j = listNearOpen.Count - 1; j > i; j--)
                    {
                        if (DateTime.Compare(listNearOpen[j].publishAt.Value, listNearOpen[j - 1].publishAt.Value) < 0)
                        {
                            Note noteTemp = listNearOpen[j];
                            listNearOpen[j] = listNearOpen[j - 1];
                            listNearOpen[j - 1] = noteTemp;
                        }
                    }
                }

                for (int i = listNearOpen.Count - 1; i >= 0; i--)
                {
                    listBoxNearOpen.Items.Add(listNearOpen[i].filePath.ToString());
                }
            }
        }

        private void listBoxNearOpen_Leave(object sender, EventArgs e)
        {
            
        }

        private bool exists (string kind)
        {
            for (int i = 0; i < listKind.Count; i++)
            {
                if (listKind[i] == kind)
                {
                    return true;
                }
            }

            return false;
        }

        private void deleteTemp(string kind)
        {
            for (int i = 0; i < listKind.Count; i++)
            {
                if (listKind[i] == kind)
                {
                    listKind.RemoveAt(i);
                }
            }           
        }

        private void lbKind_DoubleClick(object sender, EventArgs e)
        {
            if (listKind.Count > 0)
            {     
                if (exists(lbKind.SelectedItem.ToString()))
                {
                    //txtNote.Text = "Exists";
                }
                else
                {
                    if (lbKind.SelectedIndex >= 0)
                    {
                        this.lbChooseKind.Items.Add(this.lbKind.SelectedItem);
                        listKind.Add(lbKind.SelectedItem.ToString());
                    }                   
                }                
            }
            else
            {
                if (lbKind.SelectedIndex >= 0)
                {
                    this.lbChooseKind.Items.Add(this.lbKind.SelectedItem);
                    listKind.Add(lbKind.SelectedItem.ToString());
                }                
            }
           //txtNote.Text = lbKind.SelectedItem.ToString();
        }

        private void lbChooseKind_DoubleClick(object sender, EventArgs e)
        {
            if (lbChooseKind.SelectedIndex >= 0)
            {
                deleteTemp(lbChooseKind.SelectedItem.ToString());
                lbChooseKind.Items.RemoveAt(this.lbChooseKind.SelectedIndex);
            }
        }

        private void listBoxKind_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxKind.SelectedIndex >= 0)
            {
                if(listBoxKind.SelectedIndex == 0)
                {
                    this.listBoxNearOpen.Items.Clear();

                    List<Note> listNearOpen = NoteController.getListNote();

                    //sort by time
                    for (int i = 0; i < listNearOpen.Count; i++)
                    {
                        for (int j = listNearOpen.Count - 1; j > i; j--)
                        {
                            if (DateTime.Compare(listNearOpen[j].publishAt.Value, listNearOpen[j - 1].publishAt.Value) < 0)
                            {
                                Note noteTemp = listNearOpen[j];
                                listNearOpen[j] = listNearOpen[j - 1];
                                listNearOpen[j - 1] = noteTemp;
                            }
                        }
                    }

                    for (int i = listNearOpen.Count - 1; i >= 0; i--)
                    {
                        listBoxNearOpen.Items.Add(listNearOpen[i].filePath.ToString());
                    }
                }
                else
                {
                    List<Link> listLink = LinkController.getListLink(listBoxKind.SelectedItem.ToString());

                    listBoxNearOpen.Items.Clear();

                    for (int i = 0; i < listLink.Count; i++)
                    {
                        listBoxNearOpen.Items.Add(listLink[i].note);
                    }
                }
            }
        }
    }
}
