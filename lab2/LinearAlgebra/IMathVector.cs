﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
	public interface IMathVector : IEnumerable
	{

		/// <summary>
		/// Получить размерность вектора (количество координат).
		/// </summary>
		int Dimensions { get; }

		/// <summary>
		/// Индексатор для доступа к элементам вектора. Нумерация с нуля.
		/// </summary>
		double this[int i] { get; set; }

		/// <summary>Рассчитать длину (модуль) вектора.</summary>
		double Length { get; }

		/// <summary>Покомпонентное сложение с числом.</summary>
		IMathVector SumNumber(double number);

		/// <summary>Покомпонентное умножение на число.</summary>
		IMathVector MultiplyNumber(double number);

		/// <summary>Сложение с другим вектором.</summary>
		IMathVector Sum(IMathVector vector);

		/// <summary>Покомпонентное умножение с другим вектором.</summary>
		IMathVector Multiply(IMathVector vector);

		/// <summary>Скалярное умножение на другой вектор.</summary>
		double ScalarMultiply(IMathVector vector);

		//public static  IMathVector operator +(IMathVector vector);
		/// <summary>
		/// Вывод выектора в консоль
		/// </summary>
		/// <param name="vector"></param>
		void OutputVec();


		/// <summary>
		/// Вычислить Евклидово расстояние до другого вектора.
		/// </summary>
		double CalcDistance(IMathVector vector);
	}
}
