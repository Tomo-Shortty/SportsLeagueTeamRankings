using SportsLeagueTeamRankings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace SportsLeagueTeamRankings.Services
{
    public static class ListService
    {
        public static void TransferToList<T>(List<T> oldList, List<T> newList) where T : class
        {
            foreach (T element in oldList)
            {
                newList.Add(element);
            }
        }

        public static void ClearList<T>(List<T> list) where T : class
        {
            list.Clear();
        }

        public static string WriteElementsToStringSingleLine<T>(List<T> list) where T: class
        {
            var result = "";

            foreach (T element in list)
            {
                if (element.Equals(list.Last()))
                {
                    result += element.ToString();
                }
                else
                {
                    result += element.ToString() + ", ";
                }
            }

            return result;
        }
    }
}
