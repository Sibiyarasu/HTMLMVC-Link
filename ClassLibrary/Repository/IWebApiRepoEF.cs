using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
     public interface IWebApiRepoEF
    {

        public List<EFModel> SP_EFList();
        public EFModel SP_EFListId(int Empid);
        public void SP_EFInsert(EFModel model);
        public void SP_EFUpdate(EFModel model);
        public void SP_EFDelete(int Empid);

    }
}
