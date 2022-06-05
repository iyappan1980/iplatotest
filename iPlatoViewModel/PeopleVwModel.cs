using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Data;
using iPlatoModel;
using System.Windows;
namespace iPlatoVwModel
{
    public class PeopleVwModel : PeopleModel, INotifyPropertyChanged
    {

        public int? Id
        {
            get { return pplId; }
            set
            {
                pplId = value;
                OnPropertyChanged("Id");
            }
        }


        public string? Name
        {
            get { return pplName; }
            set
            {
                pplName = value;
                OnPropertyChanged("Name");                
               
            }
        }
                
        public string? Dob
        {
            get { return pplDob; }
            set
            {
                pplDob = value;
                OnPropertyChanged("Dob");              
                
            }
        }
       
        public string? Profession
        {
            get { return pplProfession; }
            set
            {
                pplProfession = value;
                OnPropertyChanged("Profession");
            }
        }
        public DataTable? dtTable { get; set; }



        private DataRowView? selectedRow; // field

        public DataRowView? SelectedRow   // property
        {
            get { return selectedRow; }   // get method
            set
            {
                if (value != null)
                {
                    this.Id = Convert.ToInt16(value[0]);
                    this.Name = value[1].ToString();
                    this.Dob = value[2].ToString();
                    this.Profession = value[3].ToString();
                    BtnEditEnable = true;
                    BtnDeleteEnable = true;
                    TxtboxEnalbed = false;
                    BtnAddEnable = true;
                    BtnSaveEnable= false;
                }

            }  // set method
        }

        private bool txtboxEnalbed;
        public bool TxtboxEnalbed 
        {
            get { return txtboxEnalbed; }
            set
            {
                txtboxEnalbed = value;
                OnPropertyChanged("TxtboxEnalbed");
            }
        }
        private bool btnAddEnable;
        public bool BtnAddEnable
        {
            get { return btnAddEnable; }
            set
            {
                btnAddEnable = value;
                OnPropertyChanged("BtnAddEnable");
            }
        }

        private bool btnSaveEnable;
        public bool BtnSaveEnable
        {
            get { return btnSaveEnable; }
            set
            {
                btnSaveEnable = value;
                OnPropertyChanged("BtnSaveEnable");
            }
        }

        private bool btnEditEnable;
        public bool BtnEditEnable 
        {
            get { return btnEditEnable; }
            set
            {
                btnEditEnable = value;
                OnPropertyChanged("BtnEditEnable");
            }
        }
        private bool btnDeleteEnable;
        public bool BtnDeleteEnable 
        {
            get { return btnDeleteEnable; }
            set
            {
                btnDeleteEnable = value;
                OnPropertyChanged("BtnDeleteEnable");
            }
        }

        private PeopleVwModel()
        {
            TxtboxEnalbed = false;
            BtnAddEnable = true;
            BtnSaveEnable = false;
            BtnEditEnable = false;
            BtnDeleteEnable = false;

            this.tablestructure();
        }

        private static PeopleVwModel? instance;
        // Constructor is 'protected'       
        public static PeopleVwModel Instance()
        {           
            if (instance == null)
            {
                instance = new PeopleVwModel();                
            }
            return instance;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private ICommand? _AddclickCommand;
        public ICommand AddClickCommand
        {
            get
            {
                return _AddclickCommand ?? (_AddclickCommand = new CmdHandler(() => AddNewRecord(), () => CanExecute));
            }
        }

        private ICommand? _EditclickCommand;
        public ICommand EditClickCommand
        {
            get
            {
                return _EditclickCommand ?? (_EditclickCommand = new CmdHandler(() => EditRecord(), () => CanExecute));
            }
        }

        private ICommand? _DeleteclickCommand;
        public ICommand DeleteClickCommand
        {
            get
            {
                return _DeleteclickCommand ?? (_DeleteclickCommand = new CmdHandler(() => DeleteRecord(), () => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                // check if executing is allowed, i.e., validate, check if a process is running, etc. 
                return true;
            }
        }
        
        private ICommand? _SaveClickCommand;
        public ICommand SaveClickCommand
        {
            get
            {
                return _SaveClickCommand ?? (_SaveClickCommand = new CmdHandler(() => SaveRecord(), () => CanExecute));
            }
        }
        public string Action;
       
        public void AddNewRecord()
        {
            TxtboxEnalbed = true;
            BtnAddEnable = false;
            BtnSaveEnable = true;
            BtnDeleteEnable = false;
            BtnEditEnable = false;
            Action = "Add";
            clearvalues();

        }
        private void clearvalues()
        {
            this.Id = null;
            this.Name = string.Empty;
            this.Dob = string.Empty;
            this.Profession = string.Empty;


        }

        public void SaveRecord()
        {
            try
            {
                if (Action == "Add")
                {
                    if (!string.IsNullOrEmpty(this.Name))
                    {
                        DataRow drRow = dtTable.NewRow();
                        if (dtTable.Rows.Count == 0)
                        {
                            drRow["Id"] = 1;
                        }
                        else
                        {
                            decimal autonum = Convert.ToDecimal(dtTable.Compute("MAX(Id)", string.Empty));
                            drRow["Id"] = autonum + 1;
                        }

                        drRow["Name"] = this.Name;
                        drRow["Dob"] = this.Dob;
                        drRow["Profession"] = this.Profession;
                        dtTable.Rows.Add(drRow);

                        MessageBox.Show("Record Added Successfully");
                        clearvalues();
                        
                    }
                }
                else if(Action == "Update")
                {
                    if (dtTable != null)
                        if (dtTable.Rows.Count > 0)
                        {
                            if (this.Id != null)
                            {
                                DataRow[] rows = this.dtTable.Select("Id = '" + this.Id + "'");
                                if (rows.Count() > 0)
                                {
                                    foreach (DataRow row in rows)
                                    {
                                        row["Name"] = this.Name;
                                        row["Dob"] = this.Dob;
                                        row["Profession"] = this.Profession;
                                        this.dtTable.AcceptChanges();
                                    }
                                    MessageBox.Show("Record Updated Successfully");
                                    clearvalues();
                                }
                            }

                        }
                }
                BtnSaveEnable = false;
                BtnAddEnable = true;
                TxtboxEnalbed = false;
                BtnEditEnable = false;
                BtnDeleteEnable = false;
            }
            catch(Exception ex)
            { throw ex; }
        }
        public void EditRecord()
        {
            try
            {
                TxtboxEnalbed = true;
                BtnAddEnable = false;
                BtnSaveEnable = true;
                BtnDeleteEnable = false;
                BtnEditEnable = false;
                Action = "Update";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteRecord()
        {
            try
            {
                if (dtTable != null)
                    if (dtTable.Rows.Count > 0)
                    {
                        if (this.Id != null)
                        {                            
                            DataRow[] rows = this.dtTable.Select("Id = '" + this.Id + "'");
                            if (rows.Count() > 0)
                            {
                                dtTable.Rows.Remove(rows[0]);
                                dtTable.AcceptChanges();
                            }

                            MessageBox.Show("Record Deleted Successfully");
                            clearvalues();
                            BtnSaveEnable = false;
                            BtnAddEnable = true;
                            TxtboxEnalbed = false;
                            BtnEditEnable = false;
                            BtnDeleteEnable = false;
                        }
                    }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void tablestructure()
        {
            dtTable = new DataTable();
            dtTable.Columns.Add("Id", typeof(int));
            dtTable.Columns.Add("Name", typeof(string));
            dtTable.Columns.Add("Dob", typeof(string));
            dtTable.Columns.Add("Profession", typeof(string));
        }
    }
}
