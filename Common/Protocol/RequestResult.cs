﻿namespace Common.Protocol
{
	  /// <summary>
	  /// Part of RequestData
	  /// Commands return
	  /// </summary>
	  public class RequestResult
	  {
			public ResultStatus status;
			public string[] result;

			public RequestResult(ResultStatus Status, params string[] Result)
			{
				  status = Status;
				  result = Result;
			}
	  }
}