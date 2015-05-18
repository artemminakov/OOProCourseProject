using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook1
{
    public class People
    {
        public DateTime dt { get; set; }
        public string name { get; set; }
        public DateTime dataOfBirth { get; set; }
        public string address { get; set; }
        public string telphoneNumber { get; set; }
        public string work { get; set; }
        public string post { get; set; }
        public string friendsPost { get; set; }
        public string meeting { get; set; }
        public string qualities { get; set; }

        public People(string _name, DateTime _dataOfBirth, string _address, string _telephoneNumber, string _work, string _post, 
            string _friendsPost, string _meeting, string _qualities)
        {
            this.dt = DateTime.Now;
            this.name = _name;
            this.dataOfBirth = _dataOfBirth;
            this.address = _address;
            this.telphoneNumber = _telephoneNumber;
            this.work = _work;
            this.post = _post;
            this.friendsPost = _friendsPost;
            this.meeting = _meeting;
            this.qualities = _qualities;
        }
    }
}
