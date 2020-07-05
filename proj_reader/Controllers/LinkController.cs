using proj_reader.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_reader.Controllers
{
    class LinkController
    {
        public static bool addLink(Link link)
        {
            try
            {
                using (var _context = new DBReaderContext())
                {
                    _context.tbLinks.Add(link);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        
        public static bool deleteLink(Link link)
        {
            using (var _context = new DBReaderContext())
            {

                var dblink = (from u in _context.tbLinks
                              where u.ID == link.ID
                              select u).SingleOrDefault();
                _context.tbLinks.Remove(dblink);
                _context.SaveChanges();
                return true;
            }
        }
        
        public static List<Link> getListLink(string keyKind)
        {
            using (var _context = new DBReaderContext())
            {
                var kind = (from u in _context.tbLinks.AsEnumerable()
                            where u.kind.Contains(keyKind)
                            select u)
                            .Select(x => new Link
                            {
                                ID = x.ID,
                                note = x.note,
                                kind = x.kind,

                            }).ToList();
                return kind;
            }
        }

        public static List<Link> getListLinks(string keyNote)
        {
            using (var _context = new DBReaderContext())
            {
                var kind = (from u in _context.tbLinks.AsEnumerable()
                            where u.note.Contains(keyNote)
                            select u)
                            .Select(x => new Link
                            {
                                ID = x.ID,
                                note = x.note,
                                kind = x.kind,

                            }).ToList();
                return kind;
            }
        }
    }
}
