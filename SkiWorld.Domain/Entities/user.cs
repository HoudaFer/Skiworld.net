using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class user
    {
        public user()
        {
            this.claims = new List<claim>();
            this.evenements = new List<evenement>();
            this.galleries = new List<gallery>();
            this.menus = new List<menu>();
            this.parkingreservations = new List<parkingreservation>();
            this.planings = new List<planing>();
            this.purchasedetails = new List<purchasedetail>();
            this.restotables = new List<restotable>();
            this.restotablereservations = new List<restotablereservation>();
            this.roomreservations = new List<roomreservation>();
            this.skiareareservations = new List<skiareareservation>();
           
        }

        public string Status { get; set; }
        public int idUser { get; set; }
        public string adress { get; set; }
        public string cin { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public Nullable<int> experienceRes { get; set; }
        public string registrationNumber { get; set; }
        public string profilePicture { get; set; }
        public Nullable<bool> VIP { get; set; }
        public string creditCardNumber { get; set; }
        public Nullable<int> numberVisits { get; set; }
        public string experienceWorker { get; set; }
        public string registrationNumbe { get; set; }
        public string speciality { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<int> experiencePlayer { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<int> experienceEvent { get; set; }
        public string registrationNumberEvent { get; set; }
        public Nullable<int> experienceIns { get; set; }
        public Nullable<int> evenement_idEvent { get; set; }
        public virtual ICollection<claim> claims { get; set; }
        
        public virtual ICollection<evenement> evenements { get; set; }
        public virtual ICollection<gallery> galleries { get; set; }
        public virtual ICollection<menu> menus { get; set; }
        public virtual ICollection<parkingreservation> parkingreservations { get; set; }
        public virtual ICollection<planing> planings { get; set; }
        public virtual ICollection<purchasedetail> purchasedetails { get; set; }
        public virtual ICollection<restotable> restotables { get; set; }
        public virtual ICollection<restotablereservation> restotablereservations { get; set; }
        public virtual ICollection<roomreservation> roomreservations { get; set; }
        public virtual ICollection<skiareareservation> skiareareservations { get; set; }
   
    }
}
