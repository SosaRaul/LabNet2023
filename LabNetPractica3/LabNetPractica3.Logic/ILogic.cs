using LabNetPractica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3.Logic
{
    public interface ILogic<T>
    {
        void Add(T entity);
        bool Delete(int id);
        void Update(T entity);
        List<T> GetAll();


    }
}
