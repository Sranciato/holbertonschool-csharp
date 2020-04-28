﻿using System;

public enum Rating {Good, Great, Excellent}
public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    public Dog(string _name, float _age, string _owner, Rating _rating)
    {
        name = _name;
        age = _age;
        owner = _owner;
        rating = _rating;

    }
    public override string ToString()
    {
        string dogString = "Dog Name: " + name + "\n" + "Age: " + age + "\n" + "Owner: " + owner + "\n" + "Rating: " + rating;
        return dogString;
    }
}