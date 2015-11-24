# Associativy Tag Nodes Readme



## Project Description

Lightweight Associativy nodes that behave somewhat like tags.


## Documentation

This module adds the ability to use types of [Associativy](http://associativy.com/) nodes just like tags.

**This module depends on [Associativy](http://associativy.com/). Please install it first!**

The module adds the Tag Node content type, what is implicitly creatable from Associativy UIs (i.e. you can attach a new tag node to content items by just adding it and it will be created in the background) and also the Tag Nodes Part.


## Setting up Tag Nodes without writing code

Install all Associativy modules containing the following features and enable them:

- Associativy Ad-hoc Graphs
- Associativy Tag Nodes
- Associativy Frontend Engines Administration
- And a frontend engine to be able to actually display graphs, like the Jit Associativy Frontend Engine

All other dependent modules will be automatically enabled.

Then go to the Associativy menu item on the admin site and create a new graph (there's a button for it). Select all content types to be included that you want to manage in the graph and also select Tag Node.

Open the graph's page on the admin and select Tag Node as the "Implicitly creatable content type".

All done! Everything else was set up for you. Once you also create the search index for the graph (you'll be prompted for it) your graph is ready to be searched!


## Usage of Associativy Tag Nodes Part

By default the part displays all tag nodes attached to an item as a simple list. If you want to the node labels to be clickable links that lead to a list with other nodes connected to these you should set up a corresponding Projection.

The Projection should be set up to expect the tag node's label in the "TagNode" query string parameter to use for filtering. You can use the Associativy Search Filter from [Associativy Extensions](https://github.com/Lombiq/Associativy-Extensions) so the filter starts with a search working like the search box displayed at graphs. Then this Projection should be selected from under the content part's settings in the corresponding content type's editor (also take a look at the hints there).

This is done e.g. in the [Lombiq blog](http://lombiq.com/blog).

The module's source is available in two public source repositories, automatically mirrored in both directions with [Git-hg Mirror](https://githgmirror.com):

- [https://bitbucket.org/Lombiq/associativy-tag-nodes](https://bitbucket.org/Lombiq/associativy-tag-nodes) (Mercurial repository)
- [https://github.com/Lombiq/Associativy-Tag-Nodes](https://github.com/Lombiq/Associativy-Tag-Nodes) (Git repository)

Bug reports, feature requests and comments are warmly welcome, **please do so via GitHub**.
Feel free to send pull requests too, no matter which source repository you choose for this purpose.

This project is developed by [Lombiq Technologies Ltd](http://lombiq.com/). Commercial-grade support is available through Lombiq.