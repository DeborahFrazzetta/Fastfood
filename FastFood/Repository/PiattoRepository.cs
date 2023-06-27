using FastFood.Model;

namespace FastFood.Repository
{
    public class PiattoRepository
    {
        private FastFoodContext _context;
        public PiattoRepository(FastFoodContext context)
        {
            _context = context;
        }


        #region READ

        public List<Piatto> GetAll()
        {
            List<Piatto> list = _context.Piatto.ToList();
            return list;
        }

        public Piatto GetById(int id)
        {
            Piatto piatto = _context.Piatto.Find(id);
            if (piatto == null) return null;
            return piatto; 
        }

        public Piatto save(Piatto saving)
        {
            _context.Piatto.Update(saving);
            int result = _context.SaveChanges();
            if (result <= 0) return null;
            return saving;

        }
        #endregion

        #region DELETE
        public bool Delete(int ID)
        {
            Piatto piatto = _context.Piatto.Find(ID);
            if (piatto == null) return false;
            _context.Remove(piatto);
            int result = _context.SaveChanges();
            return result > 0;
        }
        #endregion


    }
}
