using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace copia_bin
{
  class copia_bin
  {
    static void Main(string[] args)
    {
      // args[0]: nome do arquivo de origem (ja existente): arq_origem
      // args[1]: nome do arquivo de destino(a ser criado): arq_destino
      Console.WriteLine("Digite os caracteres desejados:");
      string caracteresDigitados = $"{Console.ReadLine()}";
      byte[] buf = ConverteObjectEmByte($"{caracteresDigitados} *");
      byte[] buf2 = ConverteObjectEmByte(ConverteByteToString(buf).ToString().ToUpper().Replace("*", ""));
      if (File.Exists(args[0]))
      { // Aqui se tem certeza que o arquivo existe
        //Stream s1 = File.Open(@nomeArquivoOrigem, FileMode.Open);
        Stream s1 = File.Open(args[0], FileMode.Open); // abre arquivo de origem ja existente
        // Stream s2 = File.Open(@nomeArquivoDestino, FileMode.Create);
        Stream s2 = File.Open(args[1], FileMode.Create); // criar arquivo de destino  
        s1.Write(buf, 0, buf.Length);
        s1.Close();
        s1 = File.Open(args[0], FileMode.Open);
        using (BinaryReader f1 = new BinaryReader(s1))
        {
          using (BinaryWriter f2 = new BinaryWriter(s2))
          {
            while (true)
            {
              int sz = f1.Read(buf, 0, buf.Length);
              Console.WriteLine("bytes lidos = " + sz); 
              s2.Write(buf2, 0, buf2.Length);
              if (sz <= 0) break;
              f2.Write(buf, 0, sz);
              if (sz < 1024) break; // fim de arquivo
            }
          }
        }
      }
      else
      {
        Console.WriteLine("Arquivo {0} inexistente, programa encerrado", args[0]);
      }
      Console.WriteLine();
      PrintInfoArquivos(args);
      Console.WriteLine($"Entrada caracteres: { ConverteByteToString(buf)}");
      Console.WriteLine($"Caracteres digitados: {caracteresDigitados}");
      Console.WriteLine($"Caracteres convertidos: {ConverteByteToString(buf2)}");
      Console.ReadKey();
    }
     
    private static void PrintInfoArquivos(string[] args)
    {
      foreach (var item in args)
      {
        FileInfo fi = new FileInfo(item); // cria objeto Fileinfo para obter atributos do arquivo
        Console.WriteLine("Arquivo de origem: " + fi.Name); // exibe alguns atributos do arquivo
        Console.WriteLine("Diretorio: " + fi.Directory);
        Console.WriteLine("Tamanho do arquivo: {0} bytes ", fi.Length);
        Console.WriteLine("Arquivo de destino: " + args[1]);
        Console.WriteLine();
      } 
    }

    public static byte[] ConverteObjectEmByte(Object obj)
    {
      if (obj == null)
      {
        return null;
      }
      BinaryFormatter bf = new BinaryFormatter();
      MemoryStream ms = new MemoryStream();
      //cria um array de bytes através do objeto obj
      bf.Serialize(ms, obj);
      //recebe o array referente ao objeto obj
      byte[] ret = ms.ToArray();
      return ret;
    }

    public static Object ConverteByteToString(byte[] bytes)
    {
      MemoryStream memStream = new MemoryStream();
      BinaryFormatter binForm = new BinaryFormatter();
      //grava na stream o array de bytes passado como parâmetro
      memStream.Write(bytes, 0, bytes.Length);
      //modifica a posição de início da stream (posição zero)
      memStream.Seek(0, SeekOrigin.Begin);
      //converte a stream em um object
      string obj = (string)binForm.Deserialize(memStream);
      return obj;
    }
  }
}