namespace Gambling_Simulator
{
    public class GameEngine
    {
        private readonly List<GameObject> _gameObjectTable = new List<GameObject>();
        private readonly List<GameObject> _gameObjectAddedThisFrameTable = new List<GameObject>();




        public void Run()
        {
            // some bs
            const int MS_PER_FRAME = 16;

            while (true)
            {
                //
                Update(MS_PER_FRAME / 1000.0f);

                UpdateObjectTable();
            }


        }

        private void Update(float elapsed_time)
        {
            for (int object_index = 0; object_index < _gameObjectTable.Count; object_index++)
            {
                _gameObjectTable[object_index].Update(elapsed_time);
            }
        }

        public void RegisterGameObject(GameObject game_object)
        {
            _gameObjectAddedThisFrameTable.Add(game_object);
        }

        private void UpdateObjectTable()
        {
            for (int new_object_index = 0; new_object_index < _gameObjectAddedThisFrameTable.Count; new_object_index++)
            {
                _gameObjectTable.Add(_gameObjectAddedThisFrameTable[new_object_index]);
                _gameObjectAddedThisFrameTable[new_object_index].Start();
            }



        }
    }
}
