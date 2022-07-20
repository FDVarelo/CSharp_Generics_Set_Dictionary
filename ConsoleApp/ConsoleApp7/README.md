# Dictionary e SortedDictionary

• É uma coleção de pares chave / valor • Não admite repetições do objeto chave

• Os elementos são indexados pelo objeto chave (não possuem posição)

• Acesso, inserção e remoção de elementos são rápidos
• Uso comum: cookies, local storage, qualquer modelo chave-valor 

## Dictionary

• https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx

## SortedDictionary

• https://msdn.microsoft.com/en-us/library/f7fta44c(v=vs.110).aspx


## Diferenças
• Dictionary

• Armazenamento em tabela hash

• Extremamente rápido: inserção, remoção e busca O(1) 

• A ordem dos elementos não é garantida

• SortedDictionary

• Armazenamento em árvore

• Rápido: inserção, remoção e busca O(log(n)) 

• Os elementos são armazenados ordenadamente conforme implementação IComparer<T>

## Alguns métodos importantes

• dictionary[key] - acessa o elemento pela chave informada

• Add(key, value) - adiciona elemento (exceção em caso de repetição)

• Clear() - esvazia a coleção

• Count - quantidade de elementos

• ContainsKey(key) - verifica se a dada chave existe

• ContainsValue(value) - verifica se o dado valor existe

• Remove(key) - remove um elemento pela chave