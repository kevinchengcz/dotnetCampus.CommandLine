﻿using System.Collections.Immutable;
using System.Composition;
using System.Threading;

using dotnetCampus.CommandLine.Properties;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Simplification;

namespace dotnetCampus.CommandLine.Analyzers.ConvertOptionProperty
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(OptionPropertyTypeToFileInfoCodeFix)), Shared]
    public class OptionPropertyTypeToFileInfoCodeFix : ConvertOptionPropertyTypeCodeFix
    {
        public sealed override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(
            DiagnosticIds.SupportedOptionPropertyType,
            DiagnosticIds.NotSupportedOptionPropertyType);

        protected sealed override string CodeActionTitle => Resources.ConvertOptionPropertyTypeToFileInfoFix;

        protected sealed override CompilationUnitSyntax CreateTypeSyntaxNode(
            TypeSyntax oldTypeSyntax, CompilationUnitSyntax syntaxRoot, SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            return syntaxRoot.ReplaceNode(
                oldTypeSyntax,
                SyntaxFactory.ParseName("global::System.IO.FileInfo")
                    .WithAdditionalAnnotations(new SyntaxAnnotation[] { Simplifier.Annotation }));
        }
    }
}
