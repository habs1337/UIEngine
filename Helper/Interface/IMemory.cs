﻿namespace UIEngine.Helper.Interface
{
    public interface IMemory
    {
        /// <summary>
        /// Читает из процесса значение по определенному адресу
        /// </summary>
        /// <typeparam name="T">Тип значения, которое надо прочитать</typeparam>
        /// <param name="Address">Адрес для чтения</param>
        /// <returns></returns>
        unsafe T Read<T>(int Address);

        /// <summary>
        /// Записывает в память значение по определенному адресу
        /// </summary>
        /// <typeparam name="T">Тип значения (необязательно)</typeparam>
        /// <param name="Address">Адрес для записи</param>
        /// <param name="Value">Само значение</param>
        unsafe void Write<T>(int Address, T Value);
    }
}