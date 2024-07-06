using System.Collections.Generic;

namespace WeatherMapMVVM.Models.ipma
{
    public class ListIdLocal
    {
        public static List<IdLocal> LoadIDLocal()
        {
            List<IdLocal> output = new List<IdLocal>();

            output.Add(new IdLocal { GlobalIdLocal = 1010500, Local = "Aveiro" });
            output.Add(new IdLocal { GlobalIdLocal = 1020500, Local = "Beja" });
            output.Add(new IdLocal { GlobalIdLocal = 1030300, Local = "Braga" });
            output.Add(new IdLocal { GlobalIdLocal = 1030800, Local = "Guimarães" });
            output.Add(new IdLocal { GlobalIdLocal = 1040200, Local = "Bragança" });
            output.Add(new IdLocal { GlobalIdLocal = 1050200, Local = "Castelo Branco" });
            output.Add(new IdLocal { GlobalIdLocal = 1060300, Local = "Coimbra" });
            output.Add(new IdLocal { GlobalIdLocal = 1070500, Local = "Évora" });
            output.Add(new IdLocal { GlobalIdLocal = 1080500, Local = "Faro" });
            output.Add(new IdLocal { GlobalIdLocal = 1081505, Local = "Sagres" });
            output.Add(new IdLocal { GlobalIdLocal = 1081100, Local = "Portimão" });
            output.Add(new IdLocal { GlobalIdLocal = 1080800, Local = "Loulé" });
            output.Add(new IdLocal { GlobalIdLocal = 1090700, Local = "Guarda" });
            output.Add(new IdLocal { GlobalIdLocal = 1090821, Local = "Penhas Douradas" });
            output.Add(new IdLocal { GlobalIdLocal = 1100900, Local = "Leiria" });
            output.Add(new IdLocal { GlobalIdLocal = 1110600, Local = "Lisboa" });
            output.Add(new IdLocal { GlobalIdLocal = 1121400, Local = "Portalegre" });
            output.Add(new IdLocal { GlobalIdLocal = 1131200, Local = "Porto" });
            output.Add(new IdLocal { GlobalIdLocal = 1141600, Local = "Santarém" });
            output.Add(new IdLocal { GlobalIdLocal = 1151200, Local = "Setúbal" });
            output.Add(new IdLocal { GlobalIdLocal = 1151300, Local = "Sines" });
            output.Add(new IdLocal { GlobalIdLocal = 1160900, Local = "Viana do Castelo" });
            output.Add(new IdLocal { GlobalIdLocal = 1171400, Local = "Vila Real" });
            output.Add(new IdLocal { GlobalIdLocal = 1182300, Local = "Viseu" });
            output.Add(new IdLocal { GlobalIdLocal = 2310300, Local = "Funchal" });
            output.Add(new IdLocal { GlobalIdLocal = 2320100, Local = "PortoSanto" });
            output.Add(new IdLocal { GlobalIdLocal = 3410100, Local = "Vila do Porto" });
            output.Add(new IdLocal { GlobalIdLocal = 3420300, Local = "Ponta Delgada" });
            output.Add(new IdLocal { GlobalIdLocal = 3430100, Local = "Angra do Heroísmo" });
            output.Add(new IdLocal { GlobalIdLocal = 3440100, Local = "Santa Cruz da Graciosa" });
            output.Add(new IdLocal { GlobalIdLocal = 3450200, Local = "Velas" });
            output.Add(new IdLocal { GlobalIdLocal = 3460200, Local = "Madalena" });
            output.Add(new IdLocal { GlobalIdLocal = 3470100, Local = "Horta" });
            output.Add(new IdLocal { GlobalIdLocal = 3480200, Local = "Santa Cruz das Flores" });
            output.Add(new IdLocal { GlobalIdLocal = 3490100, Local = "Vila do Corvo" });
            return output;
        }

    }
}
