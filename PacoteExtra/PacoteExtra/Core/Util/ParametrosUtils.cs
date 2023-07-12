using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PacoteExtra.Core.Util
{
    public sealed class SingletonParametros
    {
        private Dictionary<string, object> _dicionario;

        private static SingletonParametros _instance;
        private SingletonParametros()
        {
            _dicionario = new Dictionary<string, object>();
        }

        public static SingletonParametros GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonParametros();
            }
            return _instance;
        }

        public void AdicioneParametros(string chave, object valor)
        {
            if (_dicionario.ContainsKey(chave))
            {
                throw new Exception($"Dicionario ja continha parametro de chave {chave}");
            }
            _dicionario.Add(chave, valor);
        }

        public object GetParametros(string chave)
        {
            object parametro = null;
            if (_dicionario.ContainsKey(chave))
            {
                parametro = _dicionario[chave];
                _dicionario.Remove(chave);
            }
            return parametro;
        }
    }
}
