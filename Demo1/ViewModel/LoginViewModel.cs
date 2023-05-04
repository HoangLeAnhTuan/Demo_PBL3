using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Demo1.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
       public bool isLogin { get; set; }
        private string _UserName;
        public string UserName {
            get {
                return _UserName;
            }
            set
            {
                _UserName = value;
                OnPropertyChanged();
            }
        }
        private string _Password;
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                OnPropertyChanged();
            }
        }
        
        public ICommand LoginCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public LoginViewModel() 
        {
            isLogin = false;
            UserName = "";
            Password = "";
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Login(p); });
            PasswordChangedCommand= new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
        }
        void Login(Window p)
        {
            using (var context = new Model.PBL3_demoEntities())
            {
                var count = context.Accounts.Where(x => x.accountName == UserName && x.accountPassword == Password).Count();
                if (count > 0)
                {
                    isLogin = true;
                    p.Close();
                }
                else
                {
                    isLogin = false;
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
        }
    }
}
