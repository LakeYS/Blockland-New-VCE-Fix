$c = 0;
$Custom_Call_Lookup[$c++ - 1] = "();";
$Custom_Call_Lookup[$c++ - 1] = "(%v0);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8,%v9);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8,%v9,%v10);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8,%v9,%v10,%v11);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8,%v9,%v10,%v11,%v12);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8,%v9,%v10,%v11,%v12,%v13);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8,%v9,%v10,%v11,%v12,%v13,%v14);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8,%v9,%v10,%v11,%v12,%v13,%v14,%v15);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8,%v9,%v10,%v11,%v12,%v13,%v14,%v15,%v16);";
$Custom_Call_Lookup[$c++ - 1] = "(%v0,%v1,%v2,%v3,%v4,%v5,%v6,%v7,%v8,%v9,%v10,%v11,%v12,%v13,%v14,%v15,%v16,%v17);";

function SimObject::Custom_Call(%this, %method, %v0, %v1, %v2, %v3, %v4, %v5, %v6,%v7, %v8, %v9, %v10, %v11, %v12, %v13, %v14, %v15, %v16, %v17)
{
    %class = %this.class;

    if(%class $= "")
    {
        %class = %this.getClassName();
    }

	if(!isFunction(%class,%method))
    {
		return "";
    }

	%numArguments = 0;

	for(%i = 0; %i < 18; %i++)
	{
		if(%v[%i] !$= "")
			%numArguments = %i + 1;
	}

	return eval(%this @ "." @ %method @ $Custom_Call_Lookup[%numArguments]);
}