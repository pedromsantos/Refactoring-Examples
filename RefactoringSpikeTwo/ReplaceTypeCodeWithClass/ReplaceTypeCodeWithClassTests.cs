﻿using NUnit.Framework;

namespace RefactoringSpikeTwo.ReplaceTypeCodeWithClass
{
    [TestFixture]
    public class ReplaceTypeCodeWithClassTests
    {
        [TestCase(Person.O)]
        [TestCase(Person.A)]
        [TestCase(Person.B)]
        [TestCase(Person.AB)]
        public void A_person_has_a_blood_group(int bloodGroup)
        {
            var person = new Person(bloodGroup);

            Assert.That(person.BloodGroup, Is.EqualTo(bloodGroup));
        }
    }
}