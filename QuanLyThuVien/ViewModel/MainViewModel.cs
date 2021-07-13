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
        public ICommand PassbookCommand { get; set; }
        public ICommand PaymentCommand { get; set; }
        public ICommand ReceiptsCommand { get; set; }
        public ICommand PassbookListViewCommand { get; set; }
        public ICommand StatisticalCommand { get; set; }
        public ICommand MonthStatisticalCommand { get; set; }
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
            PassbookCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { Passbook wd = new Passbook(); wd.ShowDialog(); });
            PaymentCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { Payment wd = new Payment(); wd.ShowDialog(); });
            ReceiptsCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { Receipts wd = new Receipts(); wd.ShowDialog(); });
            PassbookListViewCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { PassbookListView wd = new PassbookListView(); wd.ShowDialog(); });
            StatisticalCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { Statistical wd = new Statistical(); wd.ShowDialog(); });
            MonthStatisticalCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { MonthStatistical wd = new MonthStatistical(); wd.ShowDialog(); });
        }
    }
}
