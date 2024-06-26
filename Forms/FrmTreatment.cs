﻿using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Clinic_Mang_Sys.Models;
using Kimtoo.BindingProvider;
using Kimtoo.DbContext;
using ServiceStack.OrmLite;

namespace Clinic_Mang_Sys.Forms
{
    public partial class FrmTreatment : Form
    {
        private Treatment _treatment = null;

        public FrmTreatment(Appointment appointment)
        {
            InitializeComponent();


            initializeCurrancy();

            loadData(appointment);

            //update lable total
            loadTotalBilling();

            gridTreatment.Bind(_treatment.GetBilling());
            //Grid
            gridEditDelete();

            Cursor.Current = Cursors.Default;
        }

        private void loadData(Appointment appointment)
        {
            this._treatment = appointment.GetTreatment();
            if (_treatment == null)
            {
                //create Appointment
                _treatment = new Treatment { AppointmentId = appointment.Id, };
                Db.Get().Save(_treatment);
                //add defult billing
                Db.Get()
                    .Save(
                        new Bill { TreatmentId = _treatment.Id, Description = "Appointment Fee" }
                    );
                Db.Get()
                    .Save(
                        new Bill { TreatmentId = _treatment.Id, Description = "Consultation Fee" }
                    );
                Db.Get()
                    .Save(new Bill { TreatmentId = _treatment.Id, Description = "Prescriptions" });
                Db.Get()
                    .Save(new Bill { TreatmentId = _treatment.Id, Description = "Treatment Fee" });
            }
            bindingProvider1.Bind(_treatment);
        }

        private void gridEditDelete()
        {
            gridTreatment.OnDelete<Bill>((a, b) => Db.Get().Delete(a) >= 0);
            gridTreatment.OnEdit<Bill>(
                (a, b) =>
                {
                    try
                    {
                        Db.Get().Save(a);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Enter a Value without EGP");
                    }

                    loadTotalBilling();
                    return true;
                }
            );
            gridTreatment.OnError<Bill>(
                (
                    a,
                    b
                ) =>
                { /*Do Nothing*/
                }
            );
        }

        private void initializeCurrancy()
        {
            string Lang = Properties.Settings.Default.Lang;
            //Intialize Currancey
            gridTreatment.Columns[2]
                .DefaultCellStyle
                .Format = "c2";

            if (Lang == "En")
            {
                gridTreatment.CellFormatting += (obj, args) =>
                {
                    if (
                        args.RowIndex >= 0
                        && /*Not the row header*/
                        args.ColumnIndex == 2
                        && /*Desired column Index*/
                        args.Value != null
                        && args.Value != DBNull.Value
                    )
                    {
                        args.Value = $"{args.Value} EGP";
                    }
                };
            }
            //For arabic version (Not finshed)
            else if (Lang == "Ar")
            {
                gridTreatment.Columns[2].DefaultCellStyle.FormatProvider =
                    CultureInfo.GetCultureInfo("ar-EG");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Db.Get().Save(_treatment);
            bunifuSnackbar1.Show(
                this.FindForm(),
                "Saved",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success
            );
            loadTotalBilling();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            gridTreatment.Bind(_treatment.GetBilling());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            gridTreatment.Bind(new Bill() { TreatmentId = _treatment.Id }, 1);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            gridTreatment.DeleteRow<Bill>();
            loadTotalBilling();
        }

        void loadTotalBilling()
        {
            lblTotal.Text = $"Total: {_treatment.GetBilling().Sum(r => r.Amount).ToString()} EGP";
        }


        //tell Appointments that form is closed
        public event EventHandler<FormClosedEventArgs> FormTreatmentClosed;

        private void FrmTreatment_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormTreatmentClosed?.Invoke(this, new FormClosedEventArgs(e.CloseReason));
        }

        private void buttonReceipt_Click(object sender, EventArgs e)
        {
            //for loading UI
            Cursor.Current = Cursors.WaitCursor;
            //open form frmTreatment and start waiting for close
            new FrmPrint(_treatment).ShowDialog();
        }
    }
}
