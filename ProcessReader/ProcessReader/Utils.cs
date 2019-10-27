namespace ProcessReader
{
  public static class Utils
  {
    public static string GetSize(double byteCount)
    {
      string size = "0 Bytes";
      if (byteCount >= 1073741824.0)
        size = string.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
      else if (byteCount >= 1048576.0)
        size = string.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
      else if (byteCount >= 1024.0)
        size = string.Format("{0:##.##}", byteCount / 1024.0) + " KB";
      else if (byteCount > 0 && byteCount < 1024.0)
        size = byteCount.ToString() + " Bytes";

      return size;
    }
  }
}
