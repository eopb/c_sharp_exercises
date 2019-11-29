#[derive(Debug, PartialEq)]
enum Door {
    Open,
    Closed,
    Locked,
}
use Door::*;

struct House {
    number: i32,
    door: Door,
}

impl House {
    fn new() -> Self {
        Self {
            number: 44,
            door: Door::Closed,
        }
    }
}

fn main() {
    let mut home = House::new();
    home.door = Locked;
    println!(
        "The door on house number {} is {:?}",
        home.number, home.door
    );
}
