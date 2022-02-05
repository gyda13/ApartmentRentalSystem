using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class UserClass
    {
        public string UserID{get; set;}
        public string UserName{get; set;}
        public string UserEmail{get; set;}
        public string UserPhone{get; set;}
        public string UserType{get; set;}
        public string UserPassword{get; set;}    
        public UserClass(string id, string name, string email, string phone, string type, string pass) {
            UserID = id;
            UserName = name;
            UserEmail = email;
            UserPhone = phone;
            UserType = type;
            UserPassword = pass;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void InsertUserToDb()
        {
            User u = new User();
            u.UserID = UserID;
            u.UserName = UserName;
            u.UserEmail = UserEmail;
            u.UserType = UserType;
            u.UserPhone = UserPhone;
            u.UserPassword = UserPassword;        
            db.Users.InsertOnSubmit(u);
            db.SubmitChanges();                 
        }
        public  bool Isvalid(string name, string email, string id)
        {
            var q = from row in db.Users
                    where row.UserName == name
                    || row.UserEmail == email
                    || row.UserID == id
                    select row;
            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
    
    public class ApartmentClass {
       
        public string ApartmentNo { get; set; }
        public string ApartmentName { get; set; }
        public bool Status { get; set; }
        public string Category{ get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Location{ get; set; }
        public string UserID { get; set; }
        public ApartmentClass(
            string no, string Aname, bool status, string category, string price, string des, string loc,string id)
             {       
            ApartmentNo = no;
            ApartmentName = Aname;
            Status = status;
            Category = category;
            Price = price;
            Description = des;
            Location = loc;
            UserID = id;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void InsertApartmentToDb()
        {

            Apartment a = new Apartment();
            a.ApartmentNo = ApartmentNo;
            a.ApartmentName = ApartmentName;
            a.Status = Status;
            a.Category = Category;
            a.Price = Price;
            a.Description = Description;
            a.Location = Location;
            a.UserID = UserID;
            db.Apartments.InsertOnSubmit(a);
            db.SubmitChanges();

        }

    }
    public class RequestClass : ApartmentClass{
        public string RequestID { get; set; }
        public bool RequestStatus { get; set; }

   public RequestClass(string no, string Aname,bool status, string category, string price, string des, string loc,
       string id,string Rid, bool Rstatus )
            : base(no,Aname,status,category,price,des,loc,id)
        {
            RequestID = Rid;
            RequestStatus = Rstatus;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void InsertRequestToDb()
        {

            Request r = new Request();
            r.RequestID = RequestID;

            r.RequestStatus = RequestStatus;
            r.UserID = UserID;
            r.ApartmentNo = ApartmentNo;

            db.Requests.InsertOnSubmit(r);
            db.SubmitChanges();

        }

    }
}
