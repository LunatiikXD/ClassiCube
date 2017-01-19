﻿// Copyright 2014-2017 ClassicalSharp | Licensed under BSD-3
using System;
using OpenTK.Input;

namespace ClassicalSharp.Mode {

	public interface IGameMode : IGameComponent {
		
		bool HandlesKeyDown(Key key);
		void PickLeft(byte old);
		void PickMiddle(byte old);
		void PickRight(byte old, byte block);
	}
}
