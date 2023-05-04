using Demo1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Demo1.ViewModel
{
    public class AddReceivingCustomerModel:BaseViewModel
    {
        public ICommand AddRCCommand { get; set; }
        public ICommand ShowAnotherControl { get; set; }
        private UserControl _currentControl;
        public UserControl CurrentControl
        {
            get { return _currentControl; }
            set
            {
                _currentControl = value;
                OnPropertyChanged("CurrentControl");
            }
        }
        int isValid = 0;
        private string _CustomerName;
        private string _CustomerID;
        private string _CustomerAddress;
        private string _CustomerPhoneNumber;
        private string _CustomerDistrict;
        private string _CustomerCity;
        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                _CustomerName = value;
                OnPropertyChanged();
            }
        }
        public string CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
                OnPropertyChanged();
            }
        }
        public string CustomerAddress
        {
            get
            {
                return _CustomerAddress;
            }
            set
            {
                _CustomerAddress = value;
                OnPropertyChanged();
            }
        }
        public string CustomerPhoneNumber
        {
            get
            {
                return _CustomerPhoneNumber;
            }
            set
            {
                _CustomerPhoneNumber = value;
                OnPropertyChanged();
            }
        }
        public string CustomerDistrict
        {
            get
            {
                return _CustomerDistrict;
            }
            set
            {
                _CustomerDistrict = value;
                OnPropertyChanged();
            }
        }
        public string CustomerCity
        {
            get
            {
                return _CustomerCity;
            }
            set
            {
                _CustomerCity = value;
                OnPropertyChanged();
            }
        }
        public AddReceivingCustomerModel()
        {
            AddRCCommand = new RelayCommand<object>((p) =>
            {     
               using (var context = new Model.PBL3_demoEntities()){

                    var customerIDCheck = context.Customers.Where(x => x.customerID == CustomerID);
                    if (customerIDCheck == null || customerIDCheck.Count() != 0)
                    {
                        isValid = 0;
                    }
                    else isValid = 1;
                }
                
                if (string.IsNullOrEmpty(CustomerName) || string.IsNullOrEmpty(CustomerID) || string.IsNullOrEmpty(CustomerAddress) || string.IsNullOrEmpty(CustomerPhoneNumber)|| string.IsNullOrEmpty(CustomerDistrict)|| string.IsNullOrEmpty(CustomerCity))
                         isValid= 0;
                if (isValid ==0) return false;
                else return true;

               
            }, (p) =>
            {
               using (var context = new Model.PBL3_demoEntities())
               {
           
                    var newCustomer = new Customer { customerID = CustomerID, customerLocation = CustomerAddress+","+CustomerDistrict+","+CustomerCity, customerPhoneNumber = CustomerPhoneNumber, customerName = CustomerName };
                    context.Customers.Add(newCustomer);
                    context.SaveChanges();
                }
                
            });
            //ShowAnotherControl =new RelayCommand<object>((p)=> { return true; },(p)=> { CurrentChildView = new AddSendingCustomerModel(); });
        }
    }
}
