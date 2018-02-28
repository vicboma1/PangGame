using System;
using UnityEngine;

namespace Es.Vicboma.Pang.Worlds006.Utils
{
	public interface IParabolicMotion
	{			
		
		/// <summary>
		/// Update the specified x0, y0, Vi and angle.
		/// </summary>
		/// <returns>The update.</returns>
		/// <param name="x0">X0.</param>
		/// <param name="y0">Y0.</param>
		/// <param name="Vi">Vi.</param>
		/// <param name="angle">Angle.</param>
		void Update(float x0, float y0, float Vi, float angle);

		/// <summary>
		/// Velocidad Y 
		/// </summary>
		/// <returns>Viy m/s </returns>
		float Viy();

		/// <summary>
		/// Velocidad en tiempo determindado
		/// </summary>
		/// <returns>V s</returns>
		/// <param name="t">Tiempo</param>
		float Vy(float t);

		/// <summary>
		/// Velocidad X 
		/// </summary>
		/// <returns>Vix m/s</returns>
		float Vix();


		/// <summary>
		/// Tiempo altura max en Y
		/// Vx = 0
		/// </summary>
		/// <returns>TYmax s</returns>
		float TYmax(float t);


		/// <summary>
		/// Tiempo alcance max en x
		/// </summary>
		/// <returns>TXmax s</returns>
		float TXmax(float t);

		/// <summary>
		/// Altura max en Y m
		/// </summary>
		/// <returns>TYmax m</returns>
		float Ymax(float t);

		/// <summary>
		/// Xi the specified t.
		/// </summary>
		/// <returns>The xi.</returns>
		/// <param name="t">T.</param>
		float Xi(float t);

		/// <summary>
		/// X the specified t.
		/// </summary>
		/// <returns>The x.</returns>
		/// <param name="t">T.</param>
		float X(float t);

		/// <summary>
		/// Y the specified t.
		/// </summary>
		/// <returns>The y.</returns>
		/// <param name="t">T.</param>
		float Y(float t);

		/// <summary>
		/// Ancles the actual.
		/// </summary>
		/// <returns>The actual.</returns>
		/// <param name="vx">Vx.</param>
		/// <param name="vy">Vy.</param>
		float AncleActual(float vx, float vy);
	}
}
