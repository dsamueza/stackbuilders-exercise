using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidSamuezaExercise.Task
{
    public class Restriction
    {
        utility util = new utility();
        /// <summary>
        /// Metedo para evaluar las restricciones del pico y placa
        /// </summary>
        /// <param name="picoPlaca"></param>
        /// <returns></returns>
        public bool IsAllowCar(PicoPlaca picoPlaca)
        {
            String placa = picoPlaca.Placa;
            String lstdigi = placa[placa.Length - 1].ToString();

            string[] PlacaDays = util.PlacaDay(StringDay(picoPlaca.Fecha));

            if (PlacaDays.Contains(lstdigi))
            {
                if (!IsAllowHour(picoPlaca.Hora))
                    return false;
            }
            return true;
        }

        bool IsAllowHour(string hour)
        {
             try { 
            string formathour = hour.Replace(":", ",");
            double hourDecimal = Convert.ToDouble(formathour);

            if ((7.0 < hourDecimal))
                if (9.30 > hourDecimal)
                    return false;

            if ((16.0 < hourDecimal))
                if (19.30 > hourDecimal)
                    return false;
             } catch(Exception e){
                throw new System.ArgumentException("Los parametro no se encuentra en los formatos correcto", "Cast");
                return false;
            }
            
            return true;

        }
        String StringDay(String date)
        {
            try { 
                 DateTime DtInicio = System.Convert.ToDateTime(date);
                 int IntegerDay = (int)(DtInicio.DayOfWeek);
                 return IntegerDay.ToString();}
            catch(Exception e){
                throw new System.ArgumentException("Los parametro no se encuentra en los formatos correcto", "Cast");
                return "";
            }
            
            }
          
        }
    }
