class Parking
    {
        decimal InitialPrice = 2;
        decimal PricePerHour; 
        List<string> VehiclePlates;
        public Parking(){
            PricePerHour = InitialPrice * 60;
            VehiclePlates = new List<string>();
        }
        public void VehicleIn(string plate)
        {
            VehiclePlates.Add(plate);
        }
        public void VehicleOut(string plate)
        {
            VehiclePlates.Remove(plate);
        }
        public void ListVehiclePlates()
        {
            foreach(var plate in VehiclePlates)
            {
                Console.WriteLine(plate);
            }
        }
    }