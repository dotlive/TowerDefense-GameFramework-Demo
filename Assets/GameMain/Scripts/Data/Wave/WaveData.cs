namespace Flower.Data
{
    public class WaveData
    {
        private DRWave dRWave;
        private WaveElementData[] waveElementDatas;

        public int Id
        {
            get
            {
                return dRWave.Id;
            }
        }

        public float FinishWaitTIme
        {
            get
            {
                return dRWave.FinishWaitTIme;
            }
        }

        public WaveElementData[] WaveElementDatas
        {
            get
            {
                return waveElementDatas;
            }
        }

        public WaveData(DRWave dRWave, WaveElementData[] waveElementDatas)
        {
            this.dRWave = dRWave;
            this.waveElementDatas = waveElementDatas;
        }
    }
}
