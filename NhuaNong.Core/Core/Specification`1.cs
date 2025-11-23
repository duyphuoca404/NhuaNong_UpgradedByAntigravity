// Decompiled with JetBrains decompiler
// Type: NhuaNong.Core.Specification`1
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Linq.Expressions;

#nullable disable
namespace NhuaNong.Core
{
  public class Specification<T> : ISpecification<T>
  {
    private Func<T, bool> _evalFunc;
    private Expression<Func<T, bool>> _evalPredicate;

    public Specification(Expression<Func<T, bool>> predicate) => this._evalPredicate = predicate;

    private Specification()
    {
    }

    public virtual Expression<Func<T, bool>> EvalPredicate => this._evalPredicate;

    public virtual Func<T, bool> EvalFunc => this._evalFunc;
  }
}
