using proj_reader.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_reader.Controllers
{
    class KindController
    {
        public static bool addKind(Kind kind)
        {
            try
            {
                using (var _context = new DBReaderContext())
                {
                    _context.tbKinds.Add(kind);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool updateKind(Kind kind)
        {
            try
            {
                using (var _context = new DBReaderContext())
                {
                    _context.tbKinds.AddOrUpdate(kind);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool deleteKind(Kind kind)
        {
            using (var _context = new DBReaderContext())
            {

                var dbkind = (from u in _context.tbKinds
                              where u.kind == kind.kind
                              select u).SingleOrDefault();
                _context.tbKinds.Remove(dbkind);
                _context.SaveChanges();
                return true;
            }
        }
        public static List<Kind> getListKind()
        {
            using (var _context = new DBReaderContext())
            {
                var kind = (from u in _context.tbKinds.AsEnumerable()
                            select u)
                            .Select(x => new Kind
                            {
                                ID = x.ID,
                                kind = x.kind,                                

                            }).ToList();
                return kind;
            }
        }
       
        public static Kind getKind(string kind)
        {
            using (var _context = new DBReaderContext())
            {
                var kindName = (from u in _context.tbKinds
                                where u.kind == kind
                                select u).ToList();
                if (kindName.Count == 1)
                {
                    return kindName[0];
                }
                else
                    return null;
            }
        }
    }
}
