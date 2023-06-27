﻿using FastFood.Model;

namespace FastFood.Repository
{
    public class ClienteRepository
    {
        private FastFoodContext _context;

        public ClienteRepository(FastFoodContext context)
        {
            _context = context;
        }


        #region READ
        public List<Cliente> GetAll()
        {
            List<Cliente> list = _context.Cliente.ToList();
            return list;
        }


        public Cliente GetById(int id)
        {
            Cliente cliente = _context.Cliente.Find(id);
                if (cliente == null) return null;
            return cliente;
        }
        #endregion

        #region SAVE
        public Cliente Save(Cliente saving)
        {
            _context.Cliente.Update(saving);
            _context.SaveChanges();
            return saving;


        }
        #endregion

        public bool Delete(int id)
        {
            Cliente cliente = _context.Cliente.Find(id);
            if (cliente == null) return false;
            _context.Remove(cliente);
            int result = _context.SaveChanges();
            return result > 0;

        }
    }
}
