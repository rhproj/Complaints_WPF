﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaints_WPF.Models
{
    public class Complaint : INotifyPropertyChanged
    {
        private int _complaintID;
        public int ComplaintID
        {
            get { return _complaintID; }
            set { _complaintID = value; OnPropertyChanged("ComplaintID"); }
        }

        private int _enumerator;
        public int Enumerator  //needed to numerate complains in DataGrid
        {
            get { return _enumerator; }
            set { _enumerator = value; OnPropertyChanged("Enumerator"); }
        }

        private DateTime _receiptDate;
        public DateTime ReceiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; OnPropertyChanged("ReceiptDate"); }
        }

        private string _complaintText;
        public string ComplaintText
        {
            get { return _complaintText; }
            set { _complaintText = value; OnPropertyChanged("ComplaintText"); }
        }

        //added later
        private string _pageNum;
        public string PageNum
        {
            get { return _pageNum; }
            set { _pageNum = value; OnPropertyChanged("PageNum"); }
        }

        private string _appendNum;
        public string AppendNum
        {
            get { return _appendNum; }
            set { _appendNum = value; OnPropertyChanged("AppendNum"); }
        }

        private string _comments;
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; OnPropertyChanged("Comments"); }
        }

        private Citizen _citizen;
        public Citizen Citizen
        {
            get { return _citizen; }
            set { _citizen = value; OnPropertyChanged("Citizen"); }
        }

        private Prosecutor _prosecutor; //do i even need it here??
        public Prosecutor Prosecutor
        {
            get { return _prosecutor; }
            set { _prosecutor = value; OnPropertyChanged("Prosecutor"); }
        }

        private Result _result;
        public Result Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged("Result"); }
        }

        #region CTOR
        public Complaint()
        {
            Citizen = new Citizen();
            Result = new Result();
            Prosecutor = new Prosecutor(); //same problem forgot to init Prosec class here to get his property
        }
        //public Complaint(Citizen citizen)
        //{
        //    this.Citizen = citizen;
        //}


        //public ComplaintDT(int id, DateTime dateTime, int citizenId, string name, string adress, string phoneN, string complaintText)
        //{
        //    ComplaintID = id;
        //    ComplaintDateTime = dateTime;
        //    CitizenID = citizenId;
        //    CitizenName = name;
        //    CitizenAdress = adress;
        //    PhoneNumber = phoneN;
        //    ComplaintText = complaintText;
        //}

        //public ComplaintDT(int id, DateTime dateTime, string name, string complaintText)
        //{
        //    ComplaintID = id;
        //    ComplaintDateTime = dateTime;
        //    CitizenName = name;
        //    ComplaintText = complaintText;
        //} 
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
