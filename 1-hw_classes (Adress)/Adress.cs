using System;
namespace _1_hw_classes__adress_
{
	public class Adress
	{
		private uint _index;
		private string _country;
		private string _city;
		private string _street;
		private ushort _house;
		private ushort _apartment;

		public uint Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public ushort House { get; set; }
        public ushort Apartment { get; set; }

        public override string ToString()
        {
            return $"Adress\nIndex: {Index}\nCountry: {Country}\nCity: {City}\nStreet: {Street}\nHouse: {House}\nApartment: {Apartment}";
        }

    }
}

