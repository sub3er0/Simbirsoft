using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simbirsoft
{
    public static class DbWorker
    {
        public static ApplicationContext db = new ApplicationContext();

        public static void AddWord(String _word)
        {
            try
            {
                Word word = new Word { SplittedWord = _word, Count = 1 };
                db.Words.Add(word);
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public static void UpdateWord(String _word)
        {

            var word = db.Words.Where(w => w.SplittedWord == _word).FirstOrDefault(); ;
            word.Count += 1;
            db.SaveChanges();
        }

        public static bool IsExist(String word)
        {
            if (db.Words.Any(w => w.SplittedWord == word))
                return true;
            else
                return false;
        }
    }
}
