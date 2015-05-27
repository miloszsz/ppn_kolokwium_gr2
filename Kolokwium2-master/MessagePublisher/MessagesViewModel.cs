using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagePublisher
{
    /// <summary>
    /// Your TODO: please follow insstruction 
    /// </summary>
    public class MessagesViewModel : IMessagesViewModel
    {
        private readonly IDispatcher _dispatcher;

        public MessagesViewModel(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;            
        }


        public string UserName
        {
            get { return lista.First().Owner; }
        }

        public UserQueue SelectedUser
        {
            get
            {
                return lista.First();
            }
            set
            {
                _currentUser = value;
            }
        }

        public IEnumerable<UserQueue> ObservedUsers
        {
            get 
            { 
                lista = Globals.GetRandomDataForAllUsers();
                return lista; 
            }
        }

        public string NewMessageText
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Windows.Input.ICommand PublishCommand
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime FromDate
        {
            get
            {
                return _fromDate;
            }
            set
            {
                value = _fromDate;
            }
        }

        public DateTime ToDate
        {
            get
            {
                return _toDate;
            }
            set
            {
                _toDate = value;
            }
        }

        public string TextFilter
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Windows.Input.ICommand FilterCommand
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<Message> FilteredMessages
        {
            get { throw new NotImplementedException(); }
        }

        public System.Windows.Input.ICommand SaveCommand
        {
            get { throw new NotImplementedException(); }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<UserQueue> lista { get; set; }

        private UserQueue _currentUser;

        private DateTime _toDate = DateTime.Today;

        private DateTime _fromDate = DateTime.Today.AddYears(-1);
    }
}
