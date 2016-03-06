using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Mahan.Infrastructure.BusinessModel;

namespace Mahan.Stations.BusinessModel
{
    public partial class DestinationProfile
    {

        // Pax C
        [NotMapped]
        public long? C_ADL_PGS
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? C_ADL_FOC
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? C_ADL_ETKT
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? C_CHD_PGS
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? C_CHD_FOC
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? C_CHD_ETKT
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? C_INF_PGS
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        
        }

        [NotMapped]
        public long? C_INF_FOC
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? C_INF_ETKT
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        //Pax Y
        [NotMapped]
        public long? Y_ADL_PGS
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? Y_ADL_FOC
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? Y_ADL_ETKT
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? Y_CHD_PGS
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? Y_CHD_FOC
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? Y_CHD_ETKT
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? Y_INF_PGS
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? Y_INF_FOC
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? Y_INF_ETKT
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        //Pax P
        [NotMapped]
        public long? P_ADL_PGS
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? P_ADL_FOC
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? P_ADL_ETKT
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? P_CHD_PGS
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? P_CHD_FOC
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? P_CHD_ETKT
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? P_INF_PGS
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? P_INF_FOC
        {
             get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

        [NotMapped]
        public long? P_INF_ETKT
        {
            get
            {
                var destinationPassenger = GetDestinationPassenger();
                return destinationPassenger.PassengerCount;
            }
            set
            {
                var destinationPassenger = GetDestinationPassenger();
                destinationPassenger.PassengerCount = value;
            }
        }

       
        //Luggage, Cargo, Mail
        [NotMapped]
        public long? PAXBAGS_Piece
        {
            get
            {
                var destinationCargo = GetDestinationCargo();
                return destinationCargo.CargoPieces;
            }
            set
            {
                var destinationCargo = GetDestinationCargo();
                destinationCargo.CargoPieces = value;
            }
        }

        [NotMapped]
        public long? PAXBAGS_Weight
        {
            get
            {
                var destinationCargo = GetDestinationCargo();
                return destinationCargo.CargoWeight;
            }
            set
            {
                var destinationCargo = GetDestinationCargo();
                destinationCargo.CargoWeight = value;
            }
        }


        [NotMapped]
        public long? CARGO_Pieces
        {
            get
            {
                var destinationCargo = GetDestinationCargo();
                return destinationCargo.CargoPieces;
            }
            set
            {
                var destinationCargo = GetDestinationCargo();
                destinationCargo.CargoPieces = value;
            }
        }

        [NotMapped]
        public long? CARGO_Weight
        {
            get
            {
                var destinationCargo = GetDestinationCargo();
                return destinationCargo.CargoWeight;
            }
            set
            {
                var destinationCargo = GetDestinationCargo();
                destinationCargo.CargoWeight = value;
            }
        }

        [NotMapped]
        public long? MAIL_Piece
        {
            get
            {
                var destinationCargo = GetDestinationCargo();
                return destinationCargo.CargoPieces;
            }
            set
            {
                var destinationCargo = GetDestinationCargo();
                destinationCargo.CargoPieces = value;
            }
        }

        [NotMapped]
        public long? MAIL_Weight
        {
            get
            {
                var destinationCargo = GetDestinationCargo();
                return destinationCargo.CargoWeight;
            }
            set
            {
                var destinationCargo = GetDestinationCargo();
                destinationCargo.CargoWeight = value;
            }
        }


        //Special Services
        [NotMapped]
        public long? AVI
        {
           
            get
            {
                var destinationSpecialService = GetDestinationSpecialService();
                return destinationSpecialService?.SpecialServiceCount;
            }
            set
            {
                var destinationSpecialService = GetDestinationSpecialService();
                destinationSpecialService.SpecialServiceCount = value;
            }
        }

        [NotMapped]
        public long? CIP
        {
            get
            {
                var destinationSpecialService = GetDestinationSpecialService();
                return destinationSpecialService?.SpecialServiceCount;
            }
            set
            {
                var destinationSpecialService = GetDestinationSpecialService();
                destinationSpecialService.SpecialServiceCount = value;
            }
        }

        [NotMapped]
        public long? HUM
        {
            get
            {
                var destinationSpecialService = GetDestinationSpecialService();
                return destinationSpecialService?.SpecialServiceCount;
            }
            set
            {
                var destinationSpecialService = GetDestinationSpecialService();
                destinationSpecialService.SpecialServiceCount = value;
            }
        }


        [NotMapped]
        public long? MEDA
        {
            get
            {
                var destinationSpecialService = GetDestinationSpecialService();
                return destinationSpecialService?.SpecialServiceCount;
            }
            set
            {
                var destinationSpecialService = GetDestinationSpecialService();
                destinationSpecialService.SpecialServiceCount = value;
            }
        }

        [NotMapped]
        public long? STCR
        {
            get
            {
                var destinationSpecialService = GetDestinationSpecialService();
                return destinationSpecialService?.SpecialServiceCount;
            }
            set
            {
                var destinationSpecialService = GetDestinationSpecialService();
                destinationSpecialService.SpecialServiceCount = value;
            }

        }

        [NotMapped]
        public long? UM
        {
            get
            {
                var destinationSpecialService = GetDestinationSpecialService();
                return destinationSpecialService?.SpecialServiceCount;
            }
            set
            {
                var destinationSpecialService = GetDestinationSpecialService();
                destinationSpecialService.SpecialServiceCount = value;
            }
        }

        [NotMapped]
        public long? VIP
        {
            get
            {
                var destinationSpecialService = GetDestinationSpecialService();
                return destinationSpecialService?.SpecialServiceCount;
            }
            set
            {
                var destinationSpecialService = GetDestinationSpecialService();
                destinationSpecialService.SpecialServiceCount = value;
            }
        }

        [NotMapped]
        public long? WCHC
        {
            get
            {
                var destinationSpecialService = GetDestinationSpecialService();
                return destinationSpecialService?.SpecialServiceCount;
            }
            set
            {
                var destinationSpecialService = GetDestinationSpecialService();
                destinationSpecialService.SpecialServiceCount = value;
            }
        }

        [NotMapped]
        public long? WCHR
        {
            get
            {
                var destinationSpecialService = GetDestinationSpecialService();
                return destinationSpecialService?.SpecialServiceCount;
            }
            set
            {
                var destinationSpecialService = GetDestinationSpecialService();
                destinationSpecialService.SpecialServiceCount = value;
            }
        }

        
        //Total 
        [NotMapped]
        public long TotalLoadPieces
        {
            get
            {
                var cargoPieces = DestinationCargos.Sum(dc => dc.CargoPieces ?? 0);
                return cargoPieces;
            }
        }

        [NotMapped]
        public long TotalLoadWeight 
        {
            get
            {
                var cargoWeight = DestinationCargos.Sum(dc => dc.CargoWeight ?? 0);
                return cargoWeight;
            } 
        }

        [NotMapped]
        public long TotalPassengers
        {
            get
            {
                var passengerCount = DestinationPassengers.Sum(dc => dc.PassengerCount ?? 0);
                return passengerCount;
            } 
        }



        //Destination passenger
        public DestinationPassenger GetDestinationPassenger([CallerMemberName]string propertyName = null)
        {
            var parts = propertyName.Split('_');

            var seatClassName = parts[0];
            var passengerTypeName = parts[1];
            var ticketTypeName = parts[2];

            var result = this.DestinationPassengers
                .FirstOrDefault(
                    d =>
                        d.SeatClass.Name.Replace("_", "") == seatClassName &&
                        d.TicketType.Name.Replace("_", "") == ticketTypeName &&
                        d.PassengerType.Name.Replace("_", "") == passengerTypeName);

            if (result == null)
                throw new Exception(String.Format("No DestinationPassenger for: {0}", propertyName));

            return result;
        }

        //Destination Special Service
        public DestinationSpecialService GetDestinationSpecialService([CallerMemberName]string propertyName = null)
        {
            var SpecialServiceName = propertyName;

            var result = this.DestinationSpecialServices
                .FirstOrDefault(
                    d =>
                        d.SpecialServiceType.Name == SpecialServiceName);

            //if (result == null)
            //    throw new Exception(String.Format("No DestinationSpecialService for: {0}", propertyName));

            return result;
        }

        //Destination Cargo
        public DestinationCargo GetDestinationCargo ([CallerMemberName]string propertyName = null)
        {
            var parts = propertyName.Split('_');
            var cargoType = parts[0];

            var result = this.DestinationCargos
                .FirstOrDefault(
                    d =>
                        d.CargoType.Name.Replace("_","") == cargoType);

            if (result == null)
                throw new Exception(String.Format("No DestinationCargo for: {0}", propertyName));

            return result;
        }
    }
}
