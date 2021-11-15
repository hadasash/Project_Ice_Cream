using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1
{
    public class BIGML
    {
        /**
     *  Predictor for flavor from model/6190dda28be2aa39cf002c42
     *  Predictive model by BigML - Machine Learning Made Easy
*/
        public class Flavor
        {
            public static string PredictFlavor(double? month, string season, string city, string day, double? temprature, double? humidity)
            {
                if (city == null)
                {
                    return "Strawberry";
                }
                if (city.Equals("Raanana"))
                {
                    return "Dulce de leche";
                }
                if (!city.Equals("Raanana"))
                {
                    if (temprature == null)
                    {
                        return "Strawberry";
                    }
                    if (temprature > 15)
                    {
                        if (season == null)
                        {
                            return "Strawberry";
                        }
                        if (season.Equals("spring"))
                        {
                            return "Vanilla";
                        }
                        if (!season.Equals("spring"))
                        {
                            if (day == null)
                            {
                                return "Strawberry";
                            }
                            if (day.Equals("wed"))
                            {
                                return "Chocolate";
                            }
                            if (!day.Equals("wed"))
                            {
                                if (humidity == null)
                                {
                                    return "Strawberry";
                                }
                                if (humidity > 70)
                                {
                                    return "Lemon";
                                }
                                if (humidity <= 70)
                                {
                                    if (season.Equals("summer"))
                                    {
                                        if (temprature > 28)
                                        {
                                            if (month == null)
                                            {
                                                return "Strawberry";
                                            }
                                            if (month > 8)
                                            {
                                                return "Strawberry";
                                            }
                                            if (month <= 8)
                                            {
                                                if (humidity > 43)
                                                {
                                                    if (humidity > 55)
                                                    {
                                                        return "Strawberry";
                                                    }
                                                    if (humidity <= 55)
                                                    {
                                                        if (humidity > 48)
                                                        {
                                                            return "Lemon";
                                                        }
                                                        if (humidity <= 48)
                                                        {
                                                            return "Strawberry";
                                                        }
                                                    }
                                                }
                                                if (humidity <= 43)
                                                {
                                                    return "Lemon";
                                                }
                                            }
                                        }
                                        if (temprature <= 28)
                                        {
                                            return "Strawberry";
                                        }
                                    }
                                    if (!season.Equals("summer"))
                                    {
                                        return "Lemon";
                                    }
                                }
                            }
                        }
                    }
                    if (temprature <= 15)
                    {
                        if (city.Equals("Ramat Gan"))
                        {
                            return "Lemon";
                        }
                        if (!city.Equals("Ramat Gan"))
                        {
                            return "Banana Split";
                        }
                    }
                }
                return null;
            }
        }
    }
}
