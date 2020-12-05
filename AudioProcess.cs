using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio
{
    public class AudioProcess
    {
        private WaveIn waveIn;
        private WaveFileWriter writer;
        private WaveOut waveOut;
        private WaveFileReader reader;
        private Random random;

       // 

        public AudioProcess()
        {
            random = new Random();
        }
        public void Play(string outputFilename)
        {
            if (outputFilename=="")           
                return;
            
            reader = new WaveFileReader(outputFilename);
            waveOut = new WaveOut();
            waveOut.Init(reader);
            waveOut.Play();
        }
        public void Pause()
        {
            if (!HasAudio())
            {
                return;
            }
            waveOut.Pause();
        }
        public void ResumePlay()
        {
            if (!HasAudio())
            {
                return;
            }
            waveOut.Resume();
        }
        public void Stop()
        {
            if (!HasAudio())
            {
                return;
            }
            waveOut.Stop();
        }
        public void StartRecording(EventHandler<WaveInEventArgs> WaveIn_DataAvailable, EventHandler WaveIn_RecordingStopped)
        {
            string outputFilename = $@"D:\IT\repos\VideoCadr\Audio\{random.Next()}.wav";
            waveIn = new WaveIn();
            waveIn.DeviceNumber = 0;
            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.RecordingStopped += new EventHandler<StoppedEventArgs>(WaveIn_RecordingStopped);
            waveIn.WaveFormat = new WaveFormat(8000, 1);
            writer = new WaveFileWriter(outputFilename, waveIn.WaveFormat);

            waveIn.StartRecording();
        }
        public void StopRecording()
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
            }
        }
        public void WriteData(WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        public void CloseDispose()
        {
            waveIn.Dispose();
            waveIn = null;
            writer.Close();
            writer = null;
        }

        private byte[] FileToByteArray(string path)
        {
            byte[] _Buffer = null;

            FileStream _FileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader _BinaryReader = new BinaryReader(_FileStream);
            long _TotalBytes = new FileInfo(path).Length;

            _Buffer = _BinaryReader.ReadBytes((Int32)_TotalBytes);

            _FileStream.Close();         
            _FileStream.Dispose();
            _BinaryReader.Close();

            return _Buffer;
        }

        public void MakeTxtFromWav(string filepath)
        {
            if (filepath == "") return;
            byte[] res = FileToByteArray(filepath);
            string resPath = $@"D:\IT\repos\VideoCadr\Txt\{random.Next()}.txt";
            using (StreamWriter sw = new StreamWriter(resPath, false, Encoding.Default))
            {
                foreach (var item in res)
                {
                    sw.WriteLine(item);
                }
            }
        }
        public bool HasAudio()
        {
            return waveOut != null;
        }
    }
}
