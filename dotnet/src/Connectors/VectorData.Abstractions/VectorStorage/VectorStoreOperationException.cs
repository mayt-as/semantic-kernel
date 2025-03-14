﻿// Copyright (c) Microsoft. All rights reserved.

using System;

namespace Microsoft.Extensions.VectorData;

/// <summary>
/// Defines an exception that's thrown when a vector store command fails, such as upserting a record or deleting a collection.
/// </summary>
public class VectorStoreOperationException : VectorStoreException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VectorStoreOperationException"/> class.
    /// </summary>
    public VectorStoreOperationException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VectorStoreOperationException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public VectorStoreOperationException(string? message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VectorStoreOperationException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public VectorStoreOperationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
