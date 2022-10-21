//----------------------------------------------------------------------
// Title:   Support_DynamicObjectMethods
// Author:  Greek2me
// Version: 1
// Updated: January 8, 2016
//----------------------------------------------------------------------
// Include this code in your own scripts as an *individual file*
// called "Support_DynamicObjectMethods.cs". Do not modify this code.
//----------------------------------------------------------------------

if($DynamicObjectMethods::version >= 1 && !$Debug)
	return;
$DynamicObjectMethods::version = 1;

$DynamicObjectMethods::ChainBatchSize = 1000;
$DynamicObjectMethods::ChainTimeOut = 100;

//Dynamically calls methods on objects.
//@param	string method
function SimObject::call(%this, %method, %v0, %v1, %v2, %v3, %v4, %v5, %v6,
	%v7, %v8, %v9, %v10, %v11, %v12, %v13, %v14, %v15, %v16, %v17)
{
	%lastNull = -1;
	for(%i = 0; %i < 18; %i ++)
	{
		%a = %v[%i];
		if(%a $= "")
		{
			if(%lastNull < 0)
				%lastNull = %i;
			continue;
		}
		else
		{
			if(%lastNull >= 0)
			{
				for(%e = %lastNull; %e < %i; %e ++)
				{
					if(%args !$= "")
						%args = %args @ ",";
					%args = %args @ "\"\"";
				}
				%lastNull = -1;
			}
			if(%args !$= "")
				%args = %args @ ",";
			%args = %args @ "\"" @ %a @ "\"";
		}
	}

	eval(%this @ "." @ %method @ "(" @ %args @ ");");
}

//Returns the value of the given attribute.
//@param	string name
//@author	Port
function SimObject::getAttribute(%this, %name)
{
	switch (stripos("_abcdefghijklmnopqrstuvwxyz", getSubStr(%name, 0, 1)))
	{
		case  0: return %this._[getSubStr(%name, 1, strlen(%name))];
		case  1: return %this.a[getSubStr(%name, 1, strlen(%name))];
		case  2: return %this.b[getSubStr(%name, 1, strlen(%name))];
		case  3: return %this.c[getSubStr(%name, 1, strlen(%name))];
		case  4: return %this.d[getSubStr(%name, 1, strlen(%name))];
		case  5: return %this.e[getSubStr(%name, 1, strlen(%name))];
		case  6: return %this.f[getSubStr(%name, 1, strlen(%name))];
		case  7: return %this.g[getSubStr(%name, 1, strlen(%name))];
		case  8: return %this.h[getSubStr(%name, 1, strlen(%name))];
		case  9: return %this.i[getSubStr(%name, 1, strlen(%name))];
		case 10: return %this.j[getSubStr(%name, 1, strlen(%name))];
		case 11: return %this.k[getSubStr(%name, 1, strlen(%name))];
		case 12: return %this.l[getSubStr(%name, 1, strlen(%name))];
		case 13: return %this.m[getSubStr(%name, 1, strlen(%name))];
		case 14: return %this.n[getSubStr(%name, 1, strlen(%name))];
		case 15: return %this.o[getSubStr(%name, 1, strlen(%name))];
		case 16: return %this.p[getSubStr(%name, 1, strlen(%name))];
		case 17: return %this.q[getSubStr(%name, 1, strlen(%name))];
		case 18: return %this.r[getSubStr(%name, 1, strlen(%name))];
		case 19: return %this.s[getSubStr(%name, 1, strlen(%name))];
		case 20: return %this.t[getSubStr(%name, 1, strlen(%name))];
		case 21: return %this.u[getSubStr(%name, 1, strlen(%name))];
		case 22: return %this.v[getSubStr(%name, 1, strlen(%name))];
		case 23: return %this.w[getSubStr(%name, 1, strlen(%name))];
		case 24: return %this.x[getSubStr(%name, 1, strlen(%name))];
		case 25: return %this.y[getSubStr(%name, 1, strlen(%name))];
		case 26: return %this.z[getSubStr(%name, 1, strlen(%name))];
		default: return "";
	}
}

//Sets the value of the given attribute.
//@param	string name
//@author	Port
function SimObject::setAttribute(%this, %name, %value)
{
	switch (stripos("_abcdefghijklmnopqrstuvwxyz", getSubStr(%name, 0, 1)))
	{
		case  0: return %this._[getSubStr(%name, 1, strlen(%name))] = %value;
		case  1: return %this.a[getSubStr(%name, 1, strlen(%name))] = %value;
		case  2: return %this.b[getSubStr(%name, 1, strlen(%name))] = %value;
		case  3: return %this.c[getSubStr(%name, 1, strlen(%name))] = %value;
		case  4: return %this.d[getSubStr(%name, 1, strlen(%name))] = %value;
		case  5: return %this.e[getSubStr(%name, 1, strlen(%name))] = %value;
		case  6: return %this.f[getSubStr(%name, 1, strlen(%name))] = %value;
		case  7: return %this.g[getSubStr(%name, 1, strlen(%name))] = %value;
		case  8: return %this.h[getSubStr(%name, 1, strlen(%name))] = %value;
		case  9: return %this.i[getSubStr(%name, 1, strlen(%name))] = %value;
		case 10: return %this.j[getSubStr(%name, 1, strlen(%name))] = %value;
		case 11: return %this.k[getSubStr(%name, 1, strlen(%name))] = %value;
		case 12: return %this.l[getSubStr(%name, 1, strlen(%name))] = %value;
		case 13: return %this.m[getSubStr(%name, 1, strlen(%name))] = %value;
		case 14: return %this.n[getSubStr(%name, 1, strlen(%name))] = %value;
		case 15: return %this.o[getSubStr(%name, 1, strlen(%name))] = %value;
		case 16: return %this.p[getSubStr(%name, 1, strlen(%name))] = %value;
		case 17: return %this.q[getSubStr(%name, 1, strlen(%name))] = %value;
		case 18: return %this.r[getSubStr(%name, 1, strlen(%name))] = %value;
		case 19: return %this.s[getSubStr(%name, 1, strlen(%name))] = %value;
		case 20: return %this.t[getSubStr(%name, 1, strlen(%name))] = %value;
		case 21: return %this.u[getSubStr(%name, 1, strlen(%name))] = %value;
		case 22: return %this.v[getSubStr(%name, 1, strlen(%name))] = %value;
		case 23: return %this.w[getSubStr(%name, 1, strlen(%name))] = %value;
		case 24: return %this.x[getSubStr(%name, 1, strlen(%name))] = %value;
		case 25: return %this.y[getSubStr(%name, 1, strlen(%name))] = %value;
		case 26: return %this.z[getSubStr(%name, 1, strlen(%name))] = %value;
		default: return %value;
	}
}

//Copies attributes from another object.
//Does not clear existing attributes (unless overwritten).
//@param	SimObject source	The object to copy from.
function SimObject::copyAttributes(%this, %source)
{
	%index = 0;
	while((%field = %source.getTaggedField(%index)) !$= "")
	{
		//some fields cannot be changed once set...
		if(%lastField $= %field)
		{
			%index ++;
			continue;
		}
		%lastField = %field;
		%this.setAttribute(getField(%field, 0), getField(%field, 1));
	}
}

//Removes all attributes from the object.
function SimObject::clearAttributes(%this)
{
	%index = 0;
	while((%field = %this.getTaggedField(%index)) !$= "")
	{
		//some fields cannot be changed once set...
		if(%lastField $= %field)
		{
			%index ++;
			continue;
		}
		%lastField = %field;
		%this.setAttribute(getField(%field, 0), "");
	}
}

//Finds the index of a child object.
//@param	SimObject child
//@return	int	(-1 indicates error)
function SimGroup::indexOf(%this, %child)
{
	for(%i = %this.getCount() - 1; %i >= 0; %i --)
	{
		if(%child == %this.getObject(%i))
			return %i;
	}
	return -1;
}

//Performs a non-blocking call of %method on all child objects.
//@param	string method
function SimGroup::chainMethodCall(%this, %method, %v0, %v1, %v2, %v3, %v4,
	%v5, %v6, %v7, %v8, %v9, %v10, %v11, %v12, %v13, %v14, %v15, %v16, %v17)
{
	cancel(%this.chain_schedule);

	%batch = (%this.chain_batchSize $= "" ?
		$Slayer::Common::ChainBatchSize : %this.chain_batchSize);
	%count = %this.getCount();
	%index = (%this.chain_index $= "" ? %count - 1 : %this.chain_index);
	%endIndex = (%index - %batch < 0 ? 0 : %index - %batch);

	for(%i = %index; %i >= %endIndex; %i --)
	{
		%obj = %this.getObject(%i);
		%obj.call(%method, %v0, %v1, %v2, %v3, %v4, %v5, %v6, %v7, %v8, %v9,
			%v10, %v11, %v12, %v13, %v14, %v15, %v16, %v17);
	}
	%this.chain_index = %endIndex - 1;
	if(%this.chain_index <= 0)
	{
		if(isFunction(%this, %this.chain_callback))
			%this.call(%this.chain_callback);
		%this.chain_index = "";
		%this.chain_batchSize = "";
		%this.chain_timeOut = "";
		%this.chain_callback = "";
	}
	else
	{
		%time = (%this.chain_timeOut $= "" ?
			$Slayer::Common::ChainTimeOut : %this.chain_timeOut);
		%this.chain_schedule = %this.schedule(%time, "chainMethodCall",
			%method, %v0, %v1, %v2, %v3, %v4, %v5, %v6, %v7, %v8, %v9, %v10,
			%v11, %v12, %v13, %v14, %v15, %v16, %v17);
	}
}
