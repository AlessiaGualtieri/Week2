using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    public static class GestioneIO
    {
        //Creazione directory

        public static void CreaDirectory(string directoryName)
        {
            //Richiamo il percorso della cartella immagini
            string path = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyPictures), directoryName);
            DirectoryInfo directory = new DirectoryInfo(path);

            try
            {
                directory.Create();
                //Directory.CreateDirectory(path); //Analogo, non serve istanziare la DirectoryInfo
                Console.WriteLine("Creazione della cartella avvenuta con successo in \n" + path);
            }catch( IOException e )
            {
                Console.WriteLine(e.Message);
            }
        
        }

        public static void EliminaDirectory(string directoryName)
        {
            string path = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyPictures), directoryName);
            DirectoryInfo dir = new DirectoryInfo(path);
            try
            {
                dir.Delete();
                //Directory.Delete(path); //alternativa, non serve istanziare la DirectoryInfo
                Console.WriteLine("Eliminazione della cartella avvenuta con successo");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void SpostaDirectory(string folderName)
        {
            string pathSource = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyMusic), folderName);
            string pathDest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), folderName);

            
            try
            {
                Directory.CreateDirectory(pathSource);
                Console.WriteLine("Creazione cartella '{0}' avvenuta con successo", folderName);
                Console.ReadLine(); //Serve solo per interrompere l'esecuzione
                Directory.Move(pathSource, pathDest);
                Console.WriteLine("Spostamento della cartella '{0}' avvenuta con successo", folderName);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void StampaContenutoDirectory()
        {
            DirectoryInfo[] directories = new DirectoryInfo(Environment.GetFolderPath(
            Environment.SpecialFolder.MyVideos)).GetDirectories();

            foreach (var dir in directories)
                Console.Write(dir.Name + "\t");
        }

        public static void ScritturaFile(string folderName, string s)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyMusic), folderName);

            StreamWriter file = null;
            try
            {
                using ( file = File.CreateText(filePath)) //sovrascrive il file se già esiste e ci scrive su
                {
                    //file.WriteAsync("Micio bello bao bao\n \t\tBULABULABULA\n\n");
                    file.WriteAsync(s);
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }finally
            {
                file.Close();
            }

            
        }

        public static void LeggiDaFile(string folderName)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), folderName);
            string line;
            //Persona p = new Persona();
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        //string[] values = line.Split(",");
                        //p.Nome = values[0];
                        //p.Cognome = values[1];
                        //p.Eta = Convert.ToInt32( values[2]);
                        //p.DataNascita = Convert.ToDateTime( values[3] );
                        Console.WriteLine(line);
                        //break;

                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Console.WriteLine(p.ToString());
        
        }

        public static ArrayList CaricaPersoneDaFile(string folderName)
        {
            ArrayList persone = new ArrayList();
            string path = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyMusic), folderName);
            StreamReader file = null;
            string line;
            try
            { 
                using( file = File.OpenText(path))
                {
                    while ( (line = file.ReadLine() ) != null )
                    {
                        string[] values = line.Split(";");
                        Persona p = new Persona()
                        {
                            Nome = values[0],
                            Cognome = values[1],
                            Eta = Convert.ToInt32(values[2]),
                            DataNascita = Convert.ToDateTime(values[3])
                        };
                        persone.Add(p);
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                file.Close();
            }

            return persone;
        }

        public static void StampaPersoneSuFile(ArrayList persone)
        {
            string path = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop), "persone.txt");

            try
            {
                using(StreamWriter file = File.CreateText(path))
                {
                    foreach(Persona p in persone)
                        file.WriteLine(p.ToString());
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
