﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Card_tracker
{
    public class CollectionHandler
    {
        private readonly List<CardModel> collection;

        public CollectionHandler() 
        {
            LoadCollection();

            if(collection == null )
            {
                collection = new List<CardModel>();
            }
        }

        private void LoadCollection()
        {
            FileStream inputFile;

            string collectionFile = Path.Combine(FileSystem.Current.AppDataDirectory, "collection.txt");

            try
            {
                using FileStream fileIn = System.IO.File.OpenRead(collectionFile);
                inputFile = fileIn;
            } catch (System.IO.FileNotFoundException)
            {
                inputFile = null;
            }
        }

        public async void SaveCollection()
        {
            FileStream outputStream;

            string targetFile = Path.Combine(FileSystem.Current.AppDataDirectory, "collection.txt");

            try
            {
                using FileStream outStream = System.IO.File.OpenWrite(targetFile);
                outputStream = outStream;
            } catch (System.IO.FileNotFoundException)
            {
                System.IO.File.Create(targetFile);
                using FileStream outStream = System.IO.File.OpenWrite(targetFile);
                outputStream = outStream;
            }

            using StreamWriter writer = new StreamWriter(outputStream);

            foreach (CardModel model in collection)
            {
                await writer.WriteAsync(model.ToString());
            }
        }

        public void AddCard()
        {

        }
        public void RemoveCard()
        {

        }

        public void SortCollection()
        {

        }
    }
}
