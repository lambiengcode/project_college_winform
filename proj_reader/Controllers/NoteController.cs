using proj_reader.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_reader.Controllers
{
    class NoteController
    {
        public static bool addNote(Note note)
        {
            try
            {
                using (var _context = new DBReaderContext())
                {
                    _context.tbNotes.Add(note);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Note getNote(string filePath)
        {
            using (var _context = new DBReaderContext())
            {
                var note = (from u in _context.tbNotes
                            where u.filePath == filePath
                            select u).ToList();
                if (note.Count == 1)
                {
                    return note[0];
                }
                else
                    return null;
            }
        }
        public static List<Note> getListNote()
        {
            using (var _context = new DBReaderContext())
            {
                var note = (from u in _context.tbNotes.AsEnumerable()
                            select u)
                            .Select(x => new Note
                            {
                                ID = x.ID,
                                filePath = x.filePath,                                
                                publishAt = x.publishAt,
                                note = x.note,                                
                            }).ToList();
                return note;
            }
        }
        public static bool updateNote(Note note)
        {
            try
            {
                using (var _context = new DBReaderContext())
                {
                    _context.tbNotes.AddOrUpdate(note);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
