# readme

## html

- DSL
- HTML v5.x
- hypertext markup language
- structure and content
- semantic web
- element = tag + attribute + content
- tag = name of an element
- attribute = property of an element, defined at the open tag
- element = combination open and closed tag, can have self closed tag
- required html elements for the most basic page
  - <!doctype html>, <html>, <head>, <body>
- head = information of about the web page
- body = content to be displayed to the user/viewer

- history
  - html 1
  - html 2
  - html 3
  - html 4
  - html 4.1 + xhtml1 = adobe dreamweaver, microsoft frontpage, wysiwyg tooling, cms
  - html 4.1 + xhtml2
  - W3C + WHATWG (Apple, Google, Mozilla, Opera)
  - html v5
  - html
- features of HTML
  - semantic web, use the proper tags to structure content
  - header, section, nav (navigation), article, aside, footer, small (smallprint, footnote), main, i (icon)
  - native support for <audio>, <video>, <media>
  - drawing using <canvas>
  - web accessibility, microdata, RDFa
  - spacing = block element, inline element
  - storage = session, local (JS)
  - location = geolocation
- block = width of viewport
- inline = only necessary width of viewport 

## css

- cascading stylesheet
- styling and presentation
- precedence and specificity
- external (.class { color: green})< user stylesheet < browser < internal < inline (.class { color: blue})
- (0, 0, 0, 0) = !important(1000s), id(100s), class (10s), tag (1s)
- adaptive web design = styling for specific screen sizes
- responsive web design = styling for any viewport, media queries
- media query = leverage the device properties/specifications, (resolution, screen, print, aspect)
- box model = margin (between elements), border (edge of the element), padding (between edge and content), content
- box sizing = content size, border size
- selectors = <*>, <tag>, <.class>, <tag.class>, <#id>, select html element to style
- combitanor selectors
  - <selector1 selector2> = ancestor-descendant, all-related
  - <selector1 > selector2> = parent-child, directly-related
  - <selector1 + selector2> = next sibling, direct-sibling
  - <secletor1 ~ selector2> = any position sibling
- pseudo-class, pseudo-element
  - <a:link>, <a:active>, <a:hover>, <a:visited>, <input:focus>, <input:blur>
  - <div::before>, <div::after>

## dom

- document object model
- tree-like structure, where each element is a node
- see css selectors
- events = event capturing, event bubbling (JS), event listeners

## mvc

- http request lifecycle, mvc request lifecycle
- benefits = modularity (separation of concern), testability, maintainability, security
- drawbacks = complexity, competency, mid-to-large projects
- design pattern
- implementation for MSFT is ASP.NET MVC
- aspnet is server technology = web (html, css, static content), application (dynamic content, html, css, csharp)
- data binding = weak-typed view (viewbag, viewdata, tempdata), strong-typed view (viewmodel, model)
- types of views = partial view, view, layout
- webpage = layout + view + (0 or more) partial views
