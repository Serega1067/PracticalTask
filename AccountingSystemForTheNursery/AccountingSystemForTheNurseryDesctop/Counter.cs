using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystemForTheNurseryDesctop
{
    internal class Counter : IDisposable
    {
        private static int count;

        public static void add()
        {
            count++;
            using (FormAddAnimal formAddAnimal= new FormAddAnimal())
            {
                formAddAnimal.ShowDialog();
                if (formAddAnimal.IsDisposed)
                {
                    throw new NotImplementedException("Окно не закрыто!");
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
