﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        [Test]
        public void NewTestScriptSimplePasses()
        {
            GameObject sut = new GameObject("MyGameObject");
            Assert.AreEqual("MyGameObject", sut.name);
        }
    }
}
