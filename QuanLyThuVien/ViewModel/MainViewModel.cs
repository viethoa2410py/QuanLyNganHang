using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace QuanLyThuVien.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadWindowCommand { get; set; }
        public MainViewModel()
        {
            LoadWindowCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                Isloaded = true;
                MessageBox.Show("Cre: 19520552");
                Logscreen logscreen = new Logscreen();
                logscreen.ShowDialog();
            }
            );
        }
    }
}
