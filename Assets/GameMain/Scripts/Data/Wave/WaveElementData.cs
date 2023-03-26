namespace Flower.Data
{
    public class WaveElementData
    {
        private DRWaveElement dRWaveElement;

        public int Id
        {
            get
            {
                return dRWaveElement.Id;
            }
        }

        public int EnemyId
        {
            get
            {
                return dRWaveElement.EnemyId;
            }
        }

        public float SpawnTime
        {
            get
            {
                return dRWaveElement.SpawnTime;
            }
        } 

        public WaveElementData(DRWaveElement dRWaveElement)
        {
            this.dRWaveElement = dRWaveElement;
        }
    }
}
