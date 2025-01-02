using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SystemAnalysisAndDesignProject
{
    public class Vehicle
    {
        private string id;
        private CargoType cargoType; //enum
        private VehicleType vehicleType; //enum
        private float maxCapacity;
        private DateTime testDate; //datetime
        private VehicleConditionStatus vehicleConditionStatus; //enum


        public Vehicle(string id, CargoType cargoType, VehicleType vehicleType, 
            float maxCapacity, DateTime testDate, VehicleConditionStatus vehicleCondition) 
        {
            //id was already validated in the GUI and is not duplicate
            this.id = id;
            this.cargoType = cargoType;
            this.vehicleType = vehicleType;
            this.maxCapacity = maxCapacity;
            this.testDate = testDate;
            this.vehicleConditionStatus = vehicleCondition;

            this.createVehicle();
            Program.VehicleList.Add(this);


        }


        public void CreateVehicle()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_worker @id, @name, @title";

        }
        //public void create_vehicle()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE SP_add_worker @id, @name, @title";
        //    c.Parameters.AddWithValue("@id", this.WorkerId);
        //    c.Parameters.AddWithValue("@name", this.WorkerName);
        //    c.Parameters.AddWithValue("@title", this.workerTitle.ToString());
        //    SQL_CON SC = new SQL_CON();
        //    SC.execute_non_query(c);
        //}

        public string GetID()
        {
            return this.id; 
        }

        public CargoType GetCargoType()
        {
            return this.cargoType;
        }

        public VehicleType GetVehicleType()
        {
            return this.vehicleType;
        }
        public float GetMaxCapacity()
        {
            return this.maxCapacity;
        }
        public DateTime GetTestDate()
        {
            return this.testDate;
        }

        public VehicleConditionStatus GetVehicleCondition()
        {
            return this.vehicleConditionStatus;
        }

        public bool UpdateVehicleConditionStatus(VehicleConditionStatus condition)
        {
            this.vehicleConditionStatus = condition;
            return true;
        }

        public bool SetTestDate(DateTime date)
        {
            this.testDate = date;
            return true;
        }


        


    }
}
