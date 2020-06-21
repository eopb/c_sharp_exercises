use serde::Serialize;

fn main() {
    let mut hashmap = MyHashMap::new();
    hashmap.add(&"Ethan", &"Brierley");
    hashmap.add(&"Layton", &"idk");
    hashmap.add(&"Arman", &"Sattarzadeh");
    dbg!(hashmap.find(&"Ethan"));
    dbg!(hashmap.find(&"Arman"));
    dbg!(hashmap.find(&"Bob"));
}

fn hash<'a, T: Serialize>(data: &T) -> u128 {
    bincode::serialize(data)
        .unwrap()
        .iter()
        .map(|x| *x as u128)
        .sum()
}

struct MyHashMap<V>(Vec<(u128, V)>);

impl<V: Clone> MyHashMap<V> {
    fn new() -> Self {
        MyHashMap(Vec::new())
    }
    fn add<K: Serialize>(&mut self, key: &K, value: V) {
        self.0.push((hash(key), value))
    }
    fn find<K: Serialize>(&self, key: &K) -> Option<V> {
        self.0
            .iter()
            .find(|(k, _)| *k == hash(key))
            .map(|(_, v)| v.clone())
    }
}
