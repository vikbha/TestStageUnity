using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RandomGeneration
{
    public class RandomGeneration : MonoBehaviour
    {
        /// <summary>
        /// container for the random numbers
        /// </summary>
        List<int> line = new List<int>();
        int listCount = 30;

        /// <summary>
        /// This function generates random numbers between 0 and 3 (included) without any triplets
        /// </summary>
        public void GenerateRandomNumbers()
        {
            // 1st step : fill the array with random numbers
            InitialRandomNumbers(0,4);        
            while (IsRemovingElements())
            {
                // 2nd step : remove triplets
                RemoveTriplets();
                // 3rd step : fill the array and restart at step 2
                FillLine(0,4);
            }
        }

        /// <summary>
        /// completely fills the array with random numbers (a inclusive, b exclusive)
        /// </summary>
        /// <param name="a">inclusive int</param>
        /// <param name="b">exclusive int</param>
        void InitialRandomNumbers(int a, int b)
        {
            line = new List<int>();
            Debug.Log("Génération aléatoire");
            for (int i = 0; i < listCount; i++)
            {
                line.Add(Random.Range(a,b));
            }
            PrintLine();
        }

        /// <summary>
        /// this function return a bool whether there are triplets or not
        /// </summary>
        /// <returns></returns>
        bool IsRemovingElements()
        {
            bool restart = false;
            int a = line[0];
            int b = line[1];
            for (int i = 2; i < line.Count; i++)
            {
                if (line[i]==a && line[i] == b)
                {
                    restart = true;
                    break;
                }
                a = b;
                b = line[i];
            }
            return restart;
        }

        /// <summary>
        /// this function removes all triplets
        /// </summary>
        void RemoveTriplets()
        {
            Debug.Log("Suppression des groupes d’éléments identiques");
            int a = line[line.Count-1];
            int b = line[line.Count-2];
            // backward traversal because there will be item suppression
            for (int i = line.Count-3; i >= 0; i--)
            {
                if (line[i]==a && line[i] == b)
                {
                    line.RemoveAt(i);
                    line.RemoveAt(i+1);
                    line.RemoveAt(i+2);
                    break;
                }
                a = line[i+1];
                b = line[i];
            }
            PrintLine();
            if (IsRemovingElements()) // removing elements might have produced new triplets
                RemoveTriplets();
        }
    
        /// <summary>
        /// fills the array with random numbers (a inclusive, b exclusive)
        /// </summary>
        /// <param name="a">inclusive int</param>
        /// <param name="b">exclusive int</param>
        void FillLine(int a, int b)
        {
            Debug.Log("Remplissage");
            while (line.Count != listCount)
            {
                line.Add(Random.Range(a,b));
            }
            PrintLine();
        }

        /// <summary>
        /// Use this function to display the line array in the console
        /// </summary>
        void PrintLine()
        {
            string num = "";
            for (int i = 0; i < line.Count; i++)
            {
                num += line[i].ToString();
            }
            Debug.Log(num);
        }
    }
}