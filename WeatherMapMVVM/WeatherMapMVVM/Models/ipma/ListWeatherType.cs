using System.Collections.Generic;
using WeatherMapMVVM.Models.ipma;

namespace WeatherMapMVVM.Models.ipma
{
    public class ListWeatherType
    {
        public static List<IdWeatherType> LoadIDWeatherType()
        {
            List<IdWeatherType> output = new List<IdWeatherType>();

            output.Add(new IdWeatherType { IdWType = -99, WTypeImage = "", DescWeatherTypePT = "--" });
            output.Add(new IdWeatherType { IdWType = 0, WTypeImage = "", DescWeatherTypePT = "Sem informação" });
            output.Add(new IdWeatherType { IdWType = 1, WTypeImage = "ic_d_01anim.svg", DescWeatherTypePT = "Céu limpo" });
            output.Add(new IdWeatherType { IdWType = 2, WTypeImage = "ic_d_02anim.svg", DescWeatherTypePT = "Céu pouco nublado" });
            output.Add(new IdWeatherType { IdWType = 3, WTypeImage = "ic_d_03anim.svg", DescWeatherTypePT = "Céu parcialmente nublado" });
            output.Add(new IdWeatherType { IdWType = 4, WTypeImage = "ic_d_04anim.svg", DescWeatherTypePT = "Céu muito nublado ou encoberto" });
            output.Add(new IdWeatherType { IdWType = 5, WTypeImage = "ic_d_05anim.svg", DescWeatherTypePT = "Céu nublado por nuvens altas" });
            output.Add(new IdWeatherType { IdWType = 6, WTypeImage = "ic_d_06anim.svg", DescWeatherTypePT = "Aguaceiros/chuva" });
            output.Add(new IdWeatherType { IdWType = 7, WTypeImage = "ic_d_07anim.svg", DescWeatherTypePT = "Aguaceiros/chuva fracos" });
            output.Add(new IdWeatherType { IdWType = 8, WTypeImage = "ic_d_08anim.svg", DescWeatherTypePT = "Aguaceiros/rain fortes" });
            output.Add(new IdWeatherType { IdWType = 9, WTypeImage = "ic_d_09anim.svg", DescWeatherTypePT = "Chuva/aguaceiros" });
            output.Add(new IdWeatherType { IdWType = 10, WTypeImage = "ic_d_10anim.svg", DescWeatherTypePT = "Chuva fraca ou chuvisco" });
            output.Add(new IdWeatherType { IdWType = 11, WTypeImage = "ic_d_11anim.svg", DescWeatherTypePT = "Chuva/aguaceiros forte" });
            output.Add(new IdWeatherType { IdWType = 12, WTypeImage = "ic_d_12anim.svg", DescWeatherTypePT = "Períodos de chuva" });
            output.Add(new IdWeatherType { IdWType = 13, WTypeImage = "ic_d_13anim.svg", DescWeatherTypePT = "Períodos de chuva fraca" });
            output.Add(new IdWeatherType { IdWType = 14, WTypeImage = "ic_d_14anim.svg", DescWeatherTypePT = "Períodos de chuva forte" });
            output.Add(new IdWeatherType { IdWType = 15, WTypeImage = "ic_d_15anim.svg", DescWeatherTypePT = "Chuvisco" });
            output.Add(new IdWeatherType { IdWType = 16, WTypeImage = "ic_d_16anim.svg", DescWeatherTypePT = "Neblina" });
            output.Add(new IdWeatherType { IdWType = 17, WTypeImage = "ic_d_17anim.svg", DescWeatherTypePT = "Nevoeiro ou nuvens baixas" });
            output.Add(new IdWeatherType { IdWType = 18, WTypeImage = "ic_d_18anim.svg", DescWeatherTypePT = "Neve" });
            output.Add(new IdWeatherType { IdWType = 19, WTypeImage = "ic_d_19anim.svg", DescWeatherTypePT = "Trovoada" });
            output.Add(new IdWeatherType { IdWType = 20, WTypeImage = "ic_d_20anim.svg", DescWeatherTypePT = "Aguaceiros e possibilidade de trovoada" });
            output.Add(new IdWeatherType { IdWType = 21, WTypeImage = "ic_d_21anim.svg", DescWeatherTypePT = "Granizo" });
            output.Add(new IdWeatherType { IdWType = 22, WTypeImage = "ic_d_22anim.svg", DescWeatherTypePT = "Geada" });
            output.Add(new IdWeatherType { IdWType = 23, WTypeImage = "ic_d_23anim.svg", DescWeatherTypePT = "Chuva e possibilidade de trovoada" });
            output.Add(new IdWeatherType { IdWType = 24, WTypeImage = "ic_d_24anim.svg", DescWeatherTypePT = "Nebulosidade convectiva" });
            output.Add(new IdWeatherType { IdWType = 25, WTypeImage = "ic_d_25anim.svg", DescWeatherTypePT = "Céu com períodos de muito nublado" });
            output.Add(new IdWeatherType { IdWType = 26, WTypeImage = "ic_d_26anim.svg", DescWeatherTypePT = "Nevoeiro" });
            output.Add(new IdWeatherType { IdWType = 27, WTypeImage = "ic_d_27anim.svg", DescWeatherTypePT = "Céu nublado" });
            output.Add(new IdWeatherType { IdWType = 28, WTypeImage = "ic_d_28anim.svg", DescWeatherTypePT = "Aguaceiros de neve" });
            output.Add(new IdWeatherType { IdWType = 29, WTypeImage = "ic_d_29anim.svg", DescWeatherTypePT = "Chuva e Neve" });
            output.Add(new IdWeatherType { IdWType = 30, WTypeImage = "ic_d_30anim.svg", DescWeatherTypePT = "Chuva e Neve" });

            return output;
        }



    }
}
