namespace nuget2bazel
{
   public static class SdkList
   {
        public static string[] Dlls = {
            "microsoft.aspnetcore.antiforgery",
            "microsoft.aspnetcore.authentication.abstractions",
            "microsoft.aspnetcore.authentication.cookies",
            "microsoft.aspnetcore.authentication.core",
            "microsoft.aspnetcore.authentication",
            "microsoft.aspnetcore.authentication.oauth",
            "microsoft.aspnetcore.authorization",
            "microsoft.aspnetcore.authorization.policy",
            "microsoft.aspnetcore.components.authorization",
            "microsoft.aspnetcore.components",
            "microsoft.aspnetcore.components.forms",
            "microsoft.aspnetcore.components.server",
            "microsoft.aspnetcore.components.web",
            "microsoft.aspnetcore.connections.abstractions",
            "microsoft.aspnetcore.cookiepolicy",
            "microsoft.aspnetcore.cors",
            "microsoft.aspnetcore.cryptography.internal",
            "microsoft.aspnetcore.cryptography.keyderivation",
            "microsoft.aspnetcore.dataprotection.abstractions",
            "microsoft.aspnetcore.dataprotection",
            "microsoft.aspnetcore.dataprotection.extensions",
            "microsoft.aspnetcore.diagnostics.abstractions",
            "microsoft.aspnetcore.diagnostics",
            "microsoft.aspnetcore.diagnostics.healthchecks",
            "microsoft.aspnetcore",
            "microsoft.aspnetcore.hostfiltering",
            "microsoft.aspnetcore.hosting.abstractions",
            "microsoft.aspnetcore.hosting",
            "microsoft.aspnetcore.hosting.server.abstractions",
            "microsoft.aspnetcore.html.abstractions",
            "microsoft.aspnetcore.http.abstractions",
            "microsoft.aspnetcore.http.connections.common",
            "microsoft.aspnetcore.http.connections",
            "microsoft.aspnetcore.http",
            "microsoft.aspnetcore.http.extensions",
            "microsoft.aspnetcore.http.features",
            "microsoft.aspnetcore.httpoverrides",
            "microsoft.aspnetcore.httpspolicy",
            "microsoft.aspnetcore.identity",
            "microsoft.aspnetcore.localization",
            "microsoft.aspnetcore.localization.routing",
            "microsoft.aspnetcore.metadata",
            "microsoft.aspnetcore.mvc.abstractions",
            "microsoft.aspnetcore.mvc.apiexplorer",
            "microsoft.aspnetcore.mvc.core",
            "microsoft.aspnetcore.mvc.cors",
            "microsoft.aspnetcore.mvc.dataannotations",
            "microsoft.aspnetcore.mvc",
            "microsoft.aspnetcore.mvc.formatters.json",
            "microsoft.aspnetcore.mvc.formatters.xml",
            "microsoft.aspnetcore.mvc.localization",
            "microsoft.aspnetcore.mvc.razor",
            "microsoft.aspnetcore.mvc.razorpages",
            "microsoft.aspnetcore.mvc.taghelpers",
            "microsoft.aspnetcore.mvc.viewfeatures",
            "microsoft.aspnetcore.razor",
            "microsoft.aspnetcore.razor.runtime",
            "microsoft.aspnetcore.responsecaching.abstractions",
            "microsoft.aspnetcore.responsecaching",
            "microsoft.aspnetcore.responsecompression",
            "microsoft.aspnetcore.rewrite",
            "microsoft.aspnetcore.routing.abstractions",
            "microsoft.aspnetcore.routing",
            "microsoft.aspnetcore.server.httpsys",
            "microsoft.aspnetcore.server.iis",
            "microsoft.aspnetcore.server.iisintegration",
            "microsoft.aspnetcore.server.kestrel.core",
            "microsoft.aspnetcore.server.kestrel",
            "microsoft.aspnetcore.server.kestrel.transport.sockets",
            "microsoft.aspnetcore.session",
            "microsoft.aspnetcore.signalr.common",
            "microsoft.aspnetcore.signalr.core",
            "microsoft.aspnetcore.signalr",
            "microsoft.aspnetcore.signalr.protocols.json",
            "microsoft.aspnetcore.staticfiles",
            "microsoft.aspnetcore.websockets",
            "microsoft.aspnetcore.webutilities",
            "microsoft.extensions.caching.abstractions",
            "microsoft.extensions.caching.memory",
            "microsoft.extensions.configuration.abstractions",
            "microsoft.extensions.configuration.binder",
            "microsoft.extensions.configuration.commandline",
            "microsoft.extensions.configuration",
            "microsoft.extensions.configuration.environmentvariables",
            "microsoft.extensions.configuration.fileextensions",
            "microsoft.extensions.configuration.ini",
            "microsoft.extensions.configuration.json",
            "microsoft.extensions.configuration.keyperfile",
            "microsoft.extensions.configuration.usersecrets",
            "microsoft.extensions.configuration.xml",
            "microsoft.extensions.dependencyinjection.abstractions",
            "microsoft.extensions.dependencyinjection",
            "microsoft.extensions.diagnostics.healthchecks.abstractions",
            "microsoft.extensions.diagnostics.healthchecks",
            "microsoft.extensions.fileproviders.abstractions",
            "microsoft.extensions.fileproviders.composite",
            "microsoft.extensions.fileproviders.embedded",
            "microsoft.extensions.fileproviders.physical",
            "microsoft.extensions.filesystemglobbing",
            "microsoft.extensions.hosting.abstractions",
            "microsoft.extensions.hosting",
            "microsoft.extensions.http",
            "microsoft.extensions.identity.core",
            "microsoft.extensions.identity.stores",
            "microsoft.extensions.localization.abstractions",
            "microsoft.extensions.localization",
            "microsoft.extensions.logging.abstractions",
            "microsoft.extensions.logging.configuration",
            "microsoft.extensions.logging.console",
            "microsoft.extensions.logging.debug",
            "microsoft.extensions.logging",
            "microsoft.extensions.logging.eventlog",
            "microsoft.extensions.logging.eventsource",
            "microsoft.extensions.logging.tracesource",
            "microsoft.extensions.objectpool",
            "microsoft.extensions.options.configurationextensions",
            "microsoft.extensions.options.dataannotations",
            "microsoft.extensions.options",
            "microsoft.extensions.primitives",
            "microsoft.extensions.webencoders",
            "microsoft.jsinterop",
            "microsoft.net.http.headers",
            "microsoft.win32.registry",
            "system.diagnostics.eventlog",
            "system.io.pipelines",
            "system.security.accesscontrol",
            "system.security.cryptography.cng",
            "system.security.cryptography.xml",
            "system.security.permissions",
            "system.security.principal.windows",
            "system.windows.extensions",
            "microsoft.csharp",
            "microsoft.visualbasic.core",
            "microsoft.visualbasic",
            "microsoft.win32.primitives",
            "mscorlib",
            "netstandard",
            "system.appcontext",
            "system.buffers",
            "system.collections.concurrent",
            "system.collections",
            "system.collections.immutable",
            "system.collections.nongeneric",
            "system.collections.specialized",
            "system.componentmodel.annotations",
            "system.componentmodel.dataannotations",
            "system.componentmodel",
            "system.componentmodel.eventbasedasync",
            "system.componentmodel.primitives",
            "system.componentmodel.typeconverter",
            "system.configuration",
            "system.console",
            "system.core",
            "system.data.common",
            "system.data.datasetextensions",
            "system.data",
            "system.diagnostics.contracts",
            "system.diagnostics.debug",
            "system.diagnostics.diagnosticsource",
            "system.diagnostics.fileversioninfo",
            "system.diagnostics.process",
            "system.diagnostics.stacktrace",
            "system.diagnostics.textwritertracelistener",
            "system.diagnostics.tools",
            "system.diagnostics.tracesource",
            "system.diagnostics.tracing",
            "system",
            "system.drawing",
            "system.drawing.primitives",
            "system.dynamic.runtime",
            "system.globalization.calendars",
            "system.globalization",
            "system.globalization.extensions",
            "system.io.compression.brotli",
            "system.io.compression",
            "system.io.compression.filesystem",
            "system.io.compression.zipfile",
            "system.io",
            "system.io.filesystem",
            "system.io.filesystem.driveinfo",
            "system.io.filesystem.primitives",
            "system.io.filesystem.watcher",
            "system.io.isolatedstorage",
            "system.io.memorymappedfiles",
            "system.io.pipes",
            "system.io.unmanagedmemorystream",
            "system.linq",
            "system.linq.expressions",
            "system.linq.parallel",
            "system.linq.queryable",
            "system.memory",
            "system.net",
            "system.net.http",
            "system.net.httplistener",
            "system.net.mail",
            "system.net.nameresolution",
            "system.net.networkinformation",
            "system.net.ping",
            "system.net.primitives",
            "system.net.requests",
            "system.net.security",
            "system.net.servicepoint",
            "system.net.sockets",
            "system.net.webclient",
            "system.net.webheadercollection",
            "system.net.webproxy",
            "system.net.websockets.client",
            "system.net.websockets",
            "system.numerics",
            "system.numerics.vectors",
            "system.objectmodel",
            "system.reflection.dispatchproxy",
            "system.reflection",
            "system.reflection.emit",
            "system.reflection.emit.ilgeneration",
            "system.reflection.emit.lightweight",
            "system.reflection.extensions",
            "system.reflection.metadata",
            "system.reflection.primitives",
            "system.reflection.typeextensions",
            "system.resources.reader",
            "system.resources.resourcemanager",
            "system.resources.writer",
            "system.runtime.compilerservices.unsafe",
            "system.runtime.compilerservices.visualc",
            "system.runtime",
            "system.runtime.extensions",
            "system.runtime.handles",
            "system.runtime.interopservices",
            "system.runtime.interopservices.runtimeinformation",
            "system.runtime.interopservices.windowsruntime",
            "system.runtime.intrinsics",
            "system.runtime.loader",
            "system.runtime.numerics",
            "system.runtime.serialization",
            "system.runtime.serialization.formatters",
            "system.runtime.serialization.json",
            "system.runtime.serialization.primitives",
            "system.runtime.serialization.xml",
            "system.security.claims",
            "system.security.cryptography.algorithms",
            "system.security.cryptography.csp",
            "system.security.cryptography.encoding",
            "system.security.cryptography.primitives",
            "system.security.cryptography.x509certificates",
            "system.security",
            "system.security.principal",
            "system.security.securestring",
            "system.servicemodel.web",
            "system.serviceprocess",
            "system.text.encoding.codepages",
            "system.text.encoding",
            "system.text.encoding.extensions",
            "system.text.encodings.web",
            "system.text.json",
            "system.text.regularexpressions",
            "system.threading.channels",
            "system.threading",
            "system.threading.overlapped",
            "system.threading.tasks.dataflow",
            "system.threading.tasks",
            "system.threading.tasks.extensions",
            "system.threading.tasks.parallel",
            "system.threading.thread",
            "system.threading.threadpool",
            "system.threading.timer",
            "system.transactions",
            "system.transactions.local",
            "system.valuetuple",
            "system.web",
            "system.web.httputility",
            "system.windows",
            "system.xml",
            "system.xml.linq",
            "system.xml.readerwriter",
            "system.xml.serialization",
            "system.xml.xdocument",
            "system.xml.xmldocument",
            "system.xml.xmlserializer",
            "system.xml.xpath",
            "system.xml.xpath.xdocument",
            "windowsbase",
            "system.componentmodel.composition",
        };
   }
}
