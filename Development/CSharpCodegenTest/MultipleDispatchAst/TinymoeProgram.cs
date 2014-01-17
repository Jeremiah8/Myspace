using System;
using System.Collections.Generic;
using TinymoeDotNet;

namespace TinymoeProgramNamespace
{
	public class TinymoeProgram : TinymoeOperations
	{
		public readonly TinymoeObject standard_library__breaking_repeating = new TinymoeString("standard_library__breaking_repeating");

		public readonly TinymoeObject standard_library__continuing_repeating = new TinymoeString("standard_library__continuing_repeating");

		public readonly TinymoeObject standard_library__raising_exception = new TinymoeString("standard_library__raising_exception");

		public readonly TinymoeObject standard_library__exiting_program = new TinymoeString("standard_library__exiting_program");

		public readonly TinymoeObject standard_library__exiting_block = new TinymoeString("standard_library__exiting_block");

		public class standard_library__continuation_trap : TinymoeObject
		{
			public standard_library__continuation_trap()
			{
				SetField("continuation", null);
				SetField("previous_trap", null);
			}
		}

		public class standard_library__continuation_state : TinymoeObject
		{
			public standard_library__continuation_state()
			{
				SetField("flag", null);
				SetField("argument", null);
				SetField("continuation", null);
				SetField("trap", null);
			}
		}

		public void standard_library__reset_continuation_state__expression_to__expression(TinymoeObject _state, TinymoeObject state, TinymoeObject flag, TinymoeObject _continuation)
		{
		}

		public void standard_library__call__expression(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void standard_library__trap__expression(TinymoeObject state, TinymoeObject value, TinymoeObject continuation)
		{
		}

		public void standard_library__fall_into_the_previous_trap(TinymoeObject state, TinymoeObject continuation)
		{
		}

		public void standard_library__break(TinymoeObject state, TinymoeObject continuation)
		{
		}

		public void standard_library__continue(TinymoeObject state, TinymoeObject continuation)
		{
		}

		public void standard_library__raise__expression(TinymoeObject state, TinymoeObject exception, TinymoeObject continuation)
		{
		}

		public void standard_library__exit_program(TinymoeObject state, TinymoeObject continuation)
		{
		}

		public void standard_library__exit_block__expression(TinymoeObject state, TinymoeObject handle, TinymoeObject continuation)
		{
		}

		public void standard_library__repeat(TinymoeObject state, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__repeat_while__expression(TinymoeObject _state, TinymoeObject body, TinymoeObject condition, TinymoeObject _continuation)
		{
		}

		public void standard_library__repeat_with__argument_from__expression_to__expression(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject lower_bound, TinymoeObject upper_bound, TinymoeObject _continuation)
		{
		}

		public void standard_library__repeat_with__argument_in__expression(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public void standard_library__repeat_with__argument_in__expression_array_(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public void standard_library__if__expression(TinymoeObject _state, TinymoeObject body, TinymoeObject condition, TinymoeObject _continuation)
		{
		}

		public void standard_library__else_if__expression(TinymoeObject _state, TinymoeObject signal, TinymoeObject body, TinymoeObject condition, TinymoeObject _continuation)
		{
		}

		public void standard_library__else(TinymoeObject _state, TinymoeObject signal, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__try(TinymoeObject state, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__catch__argument(TinymoeObject state, TinymoeObject signal, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__finally(TinymoeObject state, TinymoeObject signal, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__named_block__argument(TinymoeObject state, TinymoeObject body, TinymoeObject _continuation)
		{
		}

		public void standard_library__add__expression_to_assignable(TinymoeObject _state, TinymoeObject value, TinymoeObject _read_variable, TinymoeObject _write_variable, TinymoeObject _continuation)
		{
		}

		public void standard_library__substract__expression_from_assignable(TinymoeObject _state, TinymoeObject value, TinymoeObject _read_variable, TinymoeObject _write_variable, TinymoeObject _continuation)
		{
		}

		public void standard_library__boolean_of__primitive(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void standard_library__integer_of__primitive(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void standard_library__floating_point_of__primitive(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void standard_library__string_of__primitive(TinymoeObject _state, TinymoeObject value, TinymoeObject _continuation)
		{
		}

		public void geometry__square_root_of__primitive(TinymoeObject _state, TinymoeObject number, TinymoeObject _continuation)
		{
		}

		public void geometry__print__expression(TinymoeObject _state, TinymoeObject message, TinymoeObject _continuation)
		{
		}

		public class geometry__rectangle : TinymoeObject
		{
			public geometry__rectangle()
			{
				SetField("width", null);
				SetField("height", null);
			}
		}

		public class geometry__triangle : TinymoeObject
		{
			public geometry__triangle()
			{
				SetField("a", null);
				SetField("b", null);
				SetField("c", null);
			}
		}

		public class geometry__circle : TinymoeObject
		{
			public geometry__circle()
			{
				SetField("radius", null);
			}
		}

		public void geometry__area_of__primitive(TinymoeObject _state, TinymoeObject shape, TinymoeObject _continuation)
		{
		}

		public void geometry__area_of__primitive_rectangle_(TinymoeObject _state, TinymoeObject shape, TinymoeObject _continuation)
		{
		}

		public void geometry__area_of__primitive_triangle_(TinymoeObject _state, TinymoeObject shape, TinymoeObject _continuation)
		{
		}

		public void geometry__area_of__primitive_circle_(TinymoeObject _state, TinymoeObject shape, TinymoeObject _continuation)
		{
		}

		public void geometry___primitive_and__expression_is_the_same_shape(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry___primitive_rectangle__and__expression_rectangle__is_the_same_shape(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry___primitive_triangle__and__expression_triangle__is_the_same_shape(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry___primitive_circle__and__expression_circle__is_the_same_shape(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry__main(TinymoeObject _state, TinymoeObject _continuation)
		{
		}

		public void _dispatch_fail__standard_library__repeat_with__argument_in__expression(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public void TinymoeArray___dispatch__standard_library__repeat_with__argument_in__expression(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public void TinymoeObject___dispatch__standard_library__repeat_with__argument_in__expression_x2(TinymoeObject _state, TinymoeObject deal_with__expression, TinymoeObject items, TinymoeObject _continuation)
		{
		}

		public void _dispatch_fail__geometry__area_of__primitive(TinymoeObject _state, TinymoeObject shape, TinymoeObject _continuation)
		{
		}

		public void geometry__rectangle___dispatch__geometry__area_of__primitive(TinymoeObject _state, TinymoeObject shape, TinymoeObject _continuation)
		{
		}

		public void geometry__triangle___dispatch__geometry__area_of__primitive_x2(TinymoeObject _state, TinymoeObject shape, TinymoeObject _continuation)
		{
		}

		public void geometry__circle___dispatch__geometry__area_of__primitive_x3(TinymoeObject _state, TinymoeObject shape, TinymoeObject _continuation)
		{
		}

		public void TinymoeObject___dispatch__geometry__area_of__primitive_x4(TinymoeObject _state, TinymoeObject shape, TinymoeObject _continuation)
		{
		}

		public void _dispatch_fail__geometry___primitive_and__expression_is_the_same_shape(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry__rectangle___dispatch__geometry___primitive_and__expression_is_the_same_shape(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry__rectangle___dispatch_geometry__rectangle_geometry___primitive_and__expression_is_the_same_shape(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry__triangle___dispatch__geometry___primitive_and__expression_is_the_same_shape_x2(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry__triangle___dispatch_geometry__triangle_geometry___primitive_and__expression_is_the_same_shape(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry__circle___dispatch__geometry___primitive_and__expression_is_the_same_shape_x3(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void geometry__circle___dispatch_geometry__circle_geometry___primitive_and__expression_is_the_same_shape(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void TinymoeObject___dispatch__geometry___primitive_and__expression_is_the_same_shape_x4(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void TinymoeObject___dispatch_geometry__circle_geometry___primitive_and__expression_is_the_same_shape_x2(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void TinymoeObject___dispatch_geometry__rectangle_geometry___primitive_and__expression_is_the_same_shape_x2(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public void TinymoeObject___dispatch_geometry__triangle_geometry___primitive_and__expression_is_the_same_shape_x2(TinymoeObject _state, TinymoeObject a, TinymoeObject b, TinymoeObject _continuation)
		{
		}

		public TinymoeProgram()
		{
			TinymoeObject.SetExtension(
				typeof(TinymoeArray),
				"_dispatch__standard_library__repeat_with__argument_in__expression",
				new TinymoeFunction(__args__ => TinymoeArray___dispatch__standard_library__repeat_with__argument_in__expression(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(TinymoeObject),
				"_dispatch__standard_library__repeat_with__argument_in__expression_x2",
				new TinymoeFunction(__args__ => TinymoeObject___dispatch__standard_library__repeat_with__argument_in__expression_x2(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(geometry__rectangle),
				"_dispatch__geometry__area_of__primitive",
				new TinymoeFunction(__args__ => geometry__rectangle___dispatch__geometry__area_of__primitive(__args__[0], __args__[1], __args__[2]))
				); 
			TinymoeObject.SetExtension(
				typeof(geometry__triangle),
				"_dispatch__geometry__area_of__primitive_x2",
				new TinymoeFunction(__args__ => geometry__triangle___dispatch__geometry__area_of__primitive_x2(__args__[0], __args__[1], __args__[2]))
				); 
			TinymoeObject.SetExtension(
				typeof(geometry__circle),
				"_dispatch__geometry__area_of__primitive_x3",
				new TinymoeFunction(__args__ => geometry__circle___dispatch__geometry__area_of__primitive_x3(__args__[0], __args__[1], __args__[2]))
				); 
			TinymoeObject.SetExtension(
				typeof(TinymoeObject),
				"_dispatch__geometry__area_of__primitive_x4",
				new TinymoeFunction(__args__ => TinymoeObject___dispatch__geometry__area_of__primitive_x4(__args__[0], __args__[1], __args__[2]))
				); 
			TinymoeObject.SetExtension(
				typeof(geometry__rectangle),
				"_dispatch__geometry___primitive_and__expression_is_the_same_shape",
				new TinymoeFunction(__args__ => geometry__rectangle___dispatch__geometry___primitive_and__expression_is_the_same_shape(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(geometry__rectangle),
				"_dispatch_geometry__rectangle_geometry___primitive_and__expression_is_the_same_shape",
				new TinymoeFunction(__args__ => geometry__rectangle___dispatch_geometry__rectangle_geometry___primitive_and__expression_is_the_same_shape(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(geometry__triangle),
				"_dispatch__geometry___primitive_and__expression_is_the_same_shape_x2",
				new TinymoeFunction(__args__ => geometry__triangle___dispatch__geometry___primitive_and__expression_is_the_same_shape_x2(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(geometry__triangle),
				"_dispatch_geometry__triangle_geometry___primitive_and__expression_is_the_same_shape",
				new TinymoeFunction(__args__ => geometry__triangle___dispatch_geometry__triangle_geometry___primitive_and__expression_is_the_same_shape(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(geometry__circle),
				"_dispatch__geometry___primitive_and__expression_is_the_same_shape_x3",
				new TinymoeFunction(__args__ => geometry__circle___dispatch__geometry___primitive_and__expression_is_the_same_shape_x3(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(geometry__circle),
				"_dispatch_geometry__circle_geometry___primitive_and__expression_is_the_same_shape",
				new TinymoeFunction(__args__ => geometry__circle___dispatch_geometry__circle_geometry___primitive_and__expression_is_the_same_shape(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(TinymoeObject),
				"_dispatch__geometry___primitive_and__expression_is_the_same_shape_x4",
				new TinymoeFunction(__args__ => TinymoeObject___dispatch__geometry___primitive_and__expression_is_the_same_shape_x4(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(TinymoeObject),
				"_dispatch_geometry__circle_geometry___primitive_and__expression_is_the_same_shape_x2",
				new TinymoeFunction(__args__ => TinymoeObject___dispatch_geometry__circle_geometry___primitive_and__expression_is_the_same_shape_x2(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(TinymoeObject),
				"_dispatch_geometry__rectangle_geometry___primitive_and__expression_is_the_same_shape_x2",
				new TinymoeFunction(__args__ => TinymoeObject___dispatch_geometry__rectangle_geometry___primitive_and__expression_is_the_same_shape_x2(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
			TinymoeObject.SetExtension(
				typeof(TinymoeObject),
				"_dispatch_geometry__triangle_geometry___primitive_and__expression_is_the_same_shape_x2",
				new TinymoeFunction(__args__ => TinymoeObject___dispatch_geometry__triangle_geometry___primitive_and__expression_is_the_same_shape_x2(__args__[0], __args__[1], __args__[2], __args__[3]))
				); 
		}
	}
}
