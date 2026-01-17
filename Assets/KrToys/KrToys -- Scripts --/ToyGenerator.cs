using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditorInternal;
using UnityEngine;
using Random = UnityEngine.Random;

namespace KrToys
{
    public class ToyGenerator : MonoBehaviour
    {
        public Transform ParentForSpawn;
        private ToyConfigSO _config;
        public GameObject tempValue;
        public ToyItem[] toys;
        public TextMeshProUGUI[] toyNames;
        public string[] toyList;
        public List<string> selectedWords = new List<string>();
        private GameObject newGm;
        public List<Toy> spawned = new List<Toy>();
        public Point[] points;

        void Start()
        {
            // по проекту никаких стрингов(выносим в отдельный класс constants) 
            _config = Resources.Load<ToyConfigSO>(constants.toyConfig); // загружаем наш конфиг
            SpawnProduct(_config.toys.Length); //вызывам метод, спавнящий наши игрушки по индексу - длины конфига с игрушками
        }

        // метод спавнящий игрушки
        public void SpawnProduct(int index)
        {
            // LinQ
            var randomElements = points // создаем лист который будет хранить наши точки и перемешивать их
                .OrderBy(x => Guid.NewGuid()) // случайная сортировка
                .Take(8) // взять 7 элементов
                .ToList(); // занести в лист
            
            // цикл для спавна объектов, плюс их регистрация 
            for (int i = 0; i < index; i++)
            {
                ToyItem toy = _config.toys[i]; // берем данные игрушек из конфига
                Toy newToy = GameObject.Instantiate(toy.objToy, randomElements[i].transform); // инстализируем переменную 
                newToy.Init(toy); // регистрируем игрушку
                newToy.name = toy.name; // делаем имя игрушки без надписи (clone) 
                spawned.Add(newToy); // добавляем нашу игрушку в массив 
                Transform prefabMesh = newToy.GetComponentInChildren<MeshRenderer>().transform;
                prefabMesh.gameObject.AddComponent<DoTweenAnim>();
            }
        }

        // метод для создания списка с игрушками(каждый раз рандомный) 
        public void ListGenerator()
        {
            List<string> allWords = new List<string>(); // создаем лист и выделяем память под него
            foreach (ToyItem toy in _config.toys) // цикл , разделяем каждое слово и добавляем слово в List
            {
                toyList = toy.name.Split("");  // разделяем каждое слово
                allWords.AddRange(toyList); // добавляем эти слова в лист (AddRange - для инстализации сразу нескольких слов, Add - для одного) 
            }

            List<string> temp = new List<string>(allWords); // создаем временный лист и передаем значения листа с именами игрушек
            selectedWords.Clear(); // очищаем список выбранных слов 
            for (int i = 0; i < 5; i++) //цикл для рандомизации списка
            {
                int index = Random.Range(0, temp.Count); //вытаскиваем случайное значение с 0 - длины временного листа
                selectedWords.Add(temp[index]); //добавляем в наш масисв выбранных слов игрушки в рандомизированном порядке 
                temp.RemoveAt(index); // очищаем значение временного списка
            }

            for (int i = 0; i < 5; i++) 
            {
                toyNames[i].text = selectedWords[i]; //выводим эти имена в TextMeshProUGUI на сцене
            }
        }

        public void ClearAllToys() // метод для удаления всех игрушек со сцены
        {
            foreach (var obj in spawned) // удаляем каждый объект с list<Toy> 
            {
                Destroy(obj.gameObject); //уничтожаем
            }

            spawned.Clear(); // очищаем сам list 
        }
    }
}