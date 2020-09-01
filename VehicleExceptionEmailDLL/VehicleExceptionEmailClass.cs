/* Title:           Vehicle Exception Email Class
 * Date:            4-25-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the class that will run the vehicle automation */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehicleExceptionEmailDLL
{
    public class VehicleExceptionEmailClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        VehicleExceptionEmailDataSet aVehicleExceptionEmailDataSet;
        VehicleExceptionEmailDataSetTableAdapters.vehicleexceptionemailTableAdapter aVehicleExceptionEmailTableAdapter;

        WeeklyVehicleReportsDateDataSet aWeeklyVehicleReportsDateDataSet;
        WeeklyVehicleReportsDateDataSetTableAdapters.weeklyvehiclereportsdateTableAdapter aWeeklyVehicleReportsDateTableAdapter;

        InsertVehicleInspectionEmailEntryTableAdapters.QueriesTableAdapter aInsertVehicleInspectionEmailTableAdapter;

        RemoveVehicleInspectionEmailEntryTableAdapters.QueriesTableAdapter aRemoveVehicleInspectionEmailTableAdapter;

        FindSortedVehicleEmailListDataSet aFindSortedVehicleEmailListDataSet;
        FindSortedVehicleEmailListDataSetTableAdapters.FindSortedVehicleEmailListTableAdapter aFindSortedVehicleEmailListTableAdapter;

        FindVehicleEmailListByEmployeeIDDataSet aFindVehicleEmailListByEmployeeIDDataSet;
        FindVehicleEmailListByEmployeeIDDataSetTableAdapters.FindVehicleEmailListByEmployeeIDTableAdapter aFindVehicleEmailListByEmployeeIDTableAdapter;

        public FindVehicleEmailListByEmployeeIDDataSet FindVehicleEmailListByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindVehicleEmailListByEmployeeIDDataSet = new FindVehicleEmailListByEmployeeIDDataSet();
                aFindVehicleEmailListByEmployeeIDTableAdapter = new FindVehicleEmailListByEmployeeIDDataSetTableAdapters.FindVehicleEmailListByEmployeeIDTableAdapter();
                aFindVehicleEmailListByEmployeeIDTableAdapter.Fill(aFindVehicleEmailListByEmployeeIDDataSet.FindVehicleEmailListByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Exception Email Class // Find Vehicle Email List By Employee ID " + Ex.Message);
            }

            return aFindVehicleEmailListByEmployeeIDDataSet;
        }
        public FindSortedVehicleEmailListDataSet FindSortedVehicleEmailList()
        {
            try
            {
                aFindSortedVehicleEmailListDataSet = new FindSortedVehicleEmailListDataSet();
                aFindSortedVehicleEmailListTableAdapter = new FindSortedVehicleEmailListDataSetTableAdapters.FindSortedVehicleEmailListTableAdapter();
                aFindSortedVehicleEmailListTableAdapter.Fill(aFindSortedVehicleEmailListDataSet.FindSortedVehicleEmailList);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Exception Email Class // Find Sorted Vehicle Inspection List " + Ex.Message);
            }

            return aFindSortedVehicleEmailListDataSet;
        }
        public bool RemoveVehicleInspectionEmail(int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveVehicleInspectionEmailTableAdapter = new RemoveVehicleInspectionEmailEntryTableAdapters.QueriesTableAdapter();
                aRemoveVehicleInspectionEmailTableAdapter.RemoveVehicleInspectionEmail(intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Exception Mail Class // Remove Vehicle Inspection Email " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertVehicleInspectionEmail(int intEmployeeID, string strEmailAddress)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleInspectionEmailTableAdapter = new InsertVehicleInspectionEmailEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleInspectionEmailTableAdapter.InsertVehicleInspectionEmail(intEmployeeID, strEmailAddress);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Exception Email Class // Insert Vehicle Inspection Email " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public WeeklyVehicleReportsDateDataSet GetWeeklyVehicleReportsDateInfo()
        {
            try
            {
                aWeeklyVehicleReportsDateDataSet = new WeeklyVehicleReportsDateDataSet();
                aWeeklyVehicleReportsDateTableAdapter = new WeeklyVehicleReportsDateDataSetTableAdapters.weeklyvehiclereportsdateTableAdapter();
                aWeeklyVehicleReportsDateTableAdapter.Fill(aWeeklyVehicleReportsDateDataSet.weeklyvehiclereportsdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Exception Eamil Class // Get Weekly Vehicle Reports Class " + Ex.Message);
            }

            return aWeeklyVehicleReportsDateDataSet;
        }
        public void UpdateWeeklyVehicleReportsDB(WeeklyVehicleReportsDateDataSet aWeeklyVehicleReportsDateDataSet)
        {
            try
            {
                aWeeklyVehicleReportsDateTableAdapter = new WeeklyVehicleReportsDateDataSetTableAdapters.weeklyvehiclereportsdateTableAdapter();
                aWeeklyVehicleReportsDateTableAdapter.Update(aWeeklyVehicleReportsDateDataSet.weeklyvehiclereportsdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Exception Eamil Class // Update Weekly Vehicle Reports DB " + Ex.Message);
            }
        }
        public VehicleExceptionEmailDataSet GetVehicleExceptionEmailInfo()
        {
            try
            {
                aVehicleExceptionEmailDataSet = new VehicleExceptionEmailDataSet();
                aVehicleExceptionEmailTableAdapter = new VehicleExceptionEmailDataSetTableAdapters.vehicleexceptionemailTableAdapter();
                aVehicleExceptionEmailTableAdapter.Fill(aVehicleExceptionEmailDataSet.vehicleexceptionemail);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Exception Email Class // Get Vehicle Exception Email Info " + Ex.Message);
            }

            return aVehicleExceptionEmailDataSet;
        }

        public void UpdateVehicleExceptionEmailDB(VehicleExceptionEmailDataSet aVehicleExceptionEmailDataSet)
        {
            try
            {
                aVehicleExceptionEmailTableAdapter = new VehicleExceptionEmailDataSetTableAdapters.vehicleexceptionemailTableAdapter();
                aVehicleExceptionEmailTableAdapter.Update(aVehicleExceptionEmailDataSet.vehicleexceptionemail);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Exception Email Class // Update Vehicle Exception Email DB " + Ex.Message);
            }
        }
    }
    
}
