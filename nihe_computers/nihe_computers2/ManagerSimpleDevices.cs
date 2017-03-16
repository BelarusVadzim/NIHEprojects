using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace nihe_computers2
{
    public class ManagerSimpleDevice
    {
        public ManagerSimpleDevice(DS_NiheComputers DS, BindingSource BSSimpleDevice)
        {
            this.DS = DS;
            this.BSSimpleDevice = BSSimpleDevice;
        }
        private BindingSource BSSimpleDevice = null;
        private DS_NiheComputers DS = null;
        public event SimpleDeviceAddDelegate SimpleDeviceAddEvent;
        public event ManagerChangeStringValueDelegate ChangeStringValueEvent;
        public event ManagerChangeListValueDelegate ChangeListValueEvent;

        public void Add()
        {
            DS_NiheComputers.SimpleDeviceRow sr = null;
            DialogSimpleDeviceAdd D = new DialogSimpleDeviceAdd();
            string infoString = null;
            if (SimpleDeviceAddEvent != null)
            {
                SimpleDeviceAddEvent(this, D);
                if (D.Changed)
                {
                    sr = DS.SimpleDevice.NewSimpleDeviceRow();
                    sr.Name = D.Name;
                    sr.DepartmentID = D.DepartmentID;
                    sr.Number = D.Number;
                    sr.PurchaseDate = D.PurchaseDate;
                    sr.WarantyDate = D.PurchaseDate.AddYears((int)D.WarantyDate);
                    sr.Room = D.Room;
                    sr.UserName = D.Username;
                    sr.VendorID = D.VendorID;
                    sr.Description = D.Description;
                    sr.DeviceTypeID = D.SimpleDeviceTypeID;
                    DS.SimpleDevice.AddSimpleDeviceRow(sr);
                    infoString = sr.FullName;
                    EventWriterSimpleDevice ewc = new EventWriterSimpleDevice(D);
                    ewc.SimpleDeviceID = sr.ID;
                    ewc.SimpleDeviceText = sr.FullName;
                    ewc.DS = DS;
                    SimpleDevice SDevice = new SimpleDevice(DS, sr);
                    ewc.EventName = "Поступление оборудования";
                    ewc.Info = SDevice.FullName;
                    if (SDevice.Number != null & SDevice.Number != "")
                        ewc.Info = string.Format("{0}\r\nИнв. №: {1}", ewc.Info, SDevice.Number);
                    if (SDevice.Vendor != null & SDevice.Vendor != " ")
                        ewc.Info = string.Format("{0}\r\nПроизвод.: {1}", ewc.Info, SDevice.Vendor);
                    if (SDevice.Department != null & SDevice.Department != "")
                        ewc.Info = string.Format("{0}\r\nСтрукт подразд.: {1}", ewc.Info, SDevice.Department);
                    if (SDevice.Name != null & SDevice.Name != "")
                        ewc.Info = string.Format("{0}\r\nМодель.: {1}", ewc.Info, SDevice.Name);
                    if (SDevice.Room != null & SDevice.Room != "")
                        ewc.Info = string.Format("{0}\r\nКабинет: {1}", ewc.Info, SDevice.Room);
                    if (SDevice.Username != null & SDevice.Username != "")
                        ewc.Info = string.Format("{0}\r\nИмя польз.: {1}", ewc.Info, SDevice.Username);
                    ewc.Write();
                    SDevice = null;
                }
            }
            D = null;
        }
        public void Move()
        {
        }


        public void ChangeRoom(SimpleDevice SDevice, string Room, DateTime Date, string ExtendInfo)
        {
            if (SDevice.Room != Room)
            {
                SDevice.Room = Room;
                WriteEvent("Изменение кабинета", Date, SDevice, ExtendInfo);
            }
        }
        public void ChangeRoom(BindingSource BSTemp)
        {
            int SDeviceID = GetidCurrentSDevice(BSTemp);
            DS_NiheComputers.SimpleDeviceRow sdr = DS.SimpleDevice.FindByID(SDeviceID);
            SimpleDevice SDevice = new SimpleDevice(DS, sdr);

            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = SDevice.Room;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeRoom(SDevice, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            SDevice = null;
        }

        public void ChangeUser(SimpleDevice SDevice, string User, DateTime Date, string ExtendInfo)
        {
            if (SDevice.Username != User)
            {
                SDevice.Username = User;
                WriteEvent("Изменение пользователя", Date, SDevice, ExtendInfo);
            }
        }
        public void ChangeUser(BindingSource BSTemp)
        {
            int SDeviceID = GetidCurrentSDevice(BSTemp);
            DS_NiheComputers.SimpleDeviceRow sdr = DS.SimpleDevice.FindByID(SDeviceID);
            SimpleDevice SDevice = new SimpleDevice(DS, sdr);

            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = SDevice.Username;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeUser(SDevice, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            SDevice = null;
        }

        public void ChangeDescription(SimpleDevice SDevice, string Description, DateTime Date, string ExtendInfo)
        {
            if (SDevice.Description != Description)
            {
                SDevice.Description = Description;
                WriteEvent("Изменение описания", Date, SDevice, ExtendInfo);
            }
        }
        public void ChangeDescription(BindingSource BSTemp)
        {
            int SDeviceID = GetidCurrentSDevice(BSTemp);
            DS_NiheComputers.SimpleDeviceRow sdr = DS.SimpleDevice.FindByID(SDeviceID);
            SimpleDevice SDevice = new SimpleDevice(DS, sdr);

            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = SDevice.Description;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeDescription(SDevice, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            SDevice = null;
        }


        public void ChangeNumber(SimpleDevice SDevice, string NewNumber, DateTime Date, string ExtendInfo)
        {
            if (SDevice.Number != NewNumber)
            {
                SDevice.Number = NewNumber;
                WriteEvent("Изменение инвентарника", Date, SDevice, ExtendInfo);
            }
        }
        public void ChangeNumber(BindingSource BSTemp)
        {
            int SDeviceID = GetidCurrentSDevice(BSTemp);
            DS_NiheComputers.SimpleDeviceRow sdr = DS.SimpleDevice.FindByID(SDeviceID);
            SimpleDevice SDevice = new SimpleDevice(DS, sdr);

            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = SDevice.Number;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeNumber(SDevice, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            SDevice = null;
        }

        public void ChangeDepartment(BindingSource BSTemp)
        {
            int SDeviceID = GetidCurrentSDevice(BSTemp);
            DS_NiheComputers.SimpleDeviceRow   sdr = DS.SimpleDevice.FindByID(SDeviceID);
            //Computer comp = new Computer(DS, cr);
            SimpleDevice sDevice = new SimpleDevice(DS, sdr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChangeDepartment);
            D.ValuesList = DS.Department.Select("name <> 'списан'", "Sort");
            D.StartValue = sDevice.DepartmentID;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                if (D.Changed)
                    ChangeDepartment(sDevice, D.EndValue, D.Date, D.ExtendedInfo);
            }
            D = null;
            sDevice = null;
        }
        public void ChangeDepartment(SimpleDevice sDevice, int NewDepartmentID, DateTime Date, string ExtendInfo)
        {
            if (sDevice.DepartmentID != NewDepartmentID)
            {
                sDevice.DepartmentID = NewDepartmentID;
                WriteEvent("Изменение отдела компьютера", Date, sDevice, ExtendInfo);
            }
        }





        private int GetidCurrentSDevice(BindingSource BS)
        {
            DataRowView drv = BS.Current as DataRowView;
            int i = (int)drv["id"];
            return i;
        }

        private void WriteEvent(string S1, DialogSimpleDevice D)
        {
            WriteEvent(S1, D.Date, D.SDevice, D.ExtendedInfo);
        }
        private void WriteEvent(string S1, DateTime D, SimpleDevice SDevice, string ExtendedInfo)
        {
            WriteEvent(S1, D, SDevice.ID, SDevice.ResultMessage, ExtendedInfo);
        }
        private void WriteEvent(string S1, DateTime D, int SDeviceID, string Info, string ExtendedInfo)
        {
            EventWriterSimpleDevice ewsd = new EventWriterSimpleDevice(DS);
            ewsd.Date = D;
            ewsd.ExtendedInfo = ExtendedInfo;
            ewsd.EventName = S1;
            ewsd.SimpleDeviceID = SDeviceID;
            if (Info != null)
                ewsd.Info = Info;
            else
                ewsd.Info = "Простое событие";
            ewsd.Write();
        }



        internal class EventWriterSimpleDevice
        {
            public EventWriterSimpleDevice(DS_NiheComputers DS)
            {
                this.DS = DS;
            }

            public EventWriterSimpleDevice(DialogSimpleDeviceAdd D)
            {
                this.Date = D.Date;
                this.ExtendedInfo = D.ExtendedInfo;
               // this.SimpleDeviceID = D.SDevice.ID;
            }


            public EventWriterSimpleDevice(DialogSimpleDevice D)
            {
                this.DS = D.DS;
                this.Date = D.Date;
                this.ExtendedInfo = D.ExtendedInfo;
                this.SimpleDeviceID = D.SDevice.ID;
            }

            public DateTime Date { get; set; }
            public string Info { get; set; }
            public int SimpleDeviceID { get; set; }
            public string ExtendedInfo { get; set; }
            public string SimpleDeviceText { get; set; }
            public string EventName { get; set; }
            public DS_NiheComputers DS { get; set; }

            public void Write()
            {
                DS_NiheComputers.SimpleDeviceEventRow sder = DS.SimpleDeviceEvent.NewSimpleDeviceEventRow();
                sder.Date = Date;
                sder.Info = Info;
                sder.SimpleDeviceID = SimpleDeviceID;
                sder.ExtendedInfo = ExtendedInfo;
                sder.SimpleDeviceText = SimpleDeviceText;
                sder.EventName = EventName;
                DS.SimpleDeviceEvent.AddSimpleDeviceEventRow(sder);
            }
        }
    }
}
